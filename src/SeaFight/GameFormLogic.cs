using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SeaFight
{
   public partial class GameForm : Form
    {

        /// <summary>
        /// Сюда будут приходить все сообщения от 2 игрока
        /// </summary>
        void WorkerRecieveMessagesEvent(string message)
        {
            //есть 5 видов сообщений: 1) при завершении игры посылается close
            //2) первое сообщение - это ник присоединившегося игрока
            //3) второе подтверждение OK_ник игрока хостера
            //4) сообщение вида 1_5 где 1 - строка, 5 столбец. причем нумерация столбцов и строк идет с 1
            //5) значение 0, 1 или 2. Это возможные результаты хода: 0 - мимо, 1 - ранил, 2 - убил

            if (message == "close")
            {
                MessageBox.Show(string.Format("Game over. {0} win!", Model.CurrentNick));
                ResetGame();
                return;
            }
            var messageItems = message.Split('_');
            if (messageItems.Length == 1 && !Utils.IsNum(messageItems[0])) 
                //нет ни одного разделения по "_", close и статус мы исключили, остается ник (2 пункт)
            {
                SetEnemyNick(message);
                Worker.SendMessage(string.Format("OK_{0}", Model.CurrentNick));
            }
            if (messageItems.Length == 2 && messageItems[0] == "OK")//пункт 3
            {
                SetEnemyNick(messageItems[1]);
                SetGameStatus(GameStatus.InGameTurn);//джойнившийся ходит первым после получения ника от сервера
            }
            if (messageItems.Length == 2 && Utils.IsNum(messageItems[0]) && Utils.IsNum(messageItems[1]))//пункт 4
            {
                int x = Convert.ToInt32(messageItems[0]) - 1;
                int y = Convert.ToInt32(messageItems[1]) - 1;
                ProcessEnemyTurn(x,y);
                CurrentBackground.Invalidate();
            }
            if (messageItems.Length == 1 && Utils.IsNum(messageItems[0])) //пункт 5
            {
                TurnsResult status =  (TurnsResult)Convert.ToInt32(messageItems[0]);//int будет приведен к enum
                //это сообщение приходит в ответ на ход текущего игрока, поэтому мы уже знаем координаты ячейки которую атаковал игрок
                //теперь когда у нас есть результат хода можно установить на ее месте точку или хит
                var lastCurrentCoords = Model.LastCurrentCoords;
                Model.Enemy[lastCurrentCoords.X][lastCurrentCoords.Y] = status == TurnsResult.Miss ? Cell.Miss : Cell.Dead;

                if (status == TurnsResult.Kill || status == TurnsResult.Hit)
                {//если игрок попал он ходит еще раз, иначе ждет сообщения с координатами хода противника
                    SetGameStatus(GameStatus.InGameTurn);
                }
                if (status == TurnsResult.Kill)
                {
                    MarkShipAsDead(Model.Enemy, lastCurrentCoords.X , lastCurrentCoords.Y);   
                }

                EnemyBackground.Invalidate();
                
            }
        }


       /// <summary>
        /// Отправляет противнику статус его хода и обновляет Model.Current в соответствии с этим ходом.
        /// Также устанавливает очередь ходить текущему игроку, если противник промазал.
       /// </summary>
       void ProcessEnemyTurn(int x,int y)
       {
           Contract.Assert(Model.Status == GameStatus.InGameWait);
           //текущий игрок во время получения этого сообщения  должен иметь статус ожидания
           Contract.Assert(Model.Current[x][y] != Cell.Miss && Model.Current[x][y] != Cell.Dead);
           //противник не мог стрельнуть в цель, которая уже отмечена как мертвая или как промах

           //получим результат хода противника для отправки ему
           var enemyStatus = CalculateTurnResult(Model.Current, x, y);

           //отобразим ход противника
           Model.Current[x][y] = enemyStatus == TurnsResult.Miss ? Cell.Miss : Cell.Dead;


           if (enemyStatus == TurnsResult.Kill)
           {
               MarkShipAsDead(Model.Current, x, y);
               //возможно противник убил последний корабль, тогда игра закончена, нужно сообщить это
               if (AllShipsDead(Model.Current))
               {
                   Worker.SendMessage("close");
                   MessageBox.Show(string.Format("Game over. {0} win!", Model.EnemyNick));
                   ResetGame();
                   return;

               }
           }

           //отправим противнику статус его хода
            Worker.SendMessage(((int)enemyStatus).ToString());
            if (enemyStatus == TurnsResult.Miss)//если противник промахнулся можно ходить
            {
                SetGameStatus(GameStatus.InGameTurn);
            }

       }

       private bool AllShipsDead(Cell[][] cells)
       {
           return cells.All(row => !row.Any(cell => cell == Cell.Life));
           //пояснение к методу: в каждой СТРОКЕ (All) нет ниодной (!Any) живой ячейки
       }

       private TurnsResult CalculateTurnResult(Cell[][] cells, int x, int y)
       {
           if (cells[x][y] == Cell.Empty)
               return TurnsResult.Miss;

           //если во все стороны от текущей клетки или мертвые клетки или ничего то корабль мертв
           var ship = GetShipCells(cells, x, y);

           bool allIsDead = true;
           foreach (Point cellCoord in ship)
           {

               if (!(cellCoord.X == x && cellCoord.Y == y) && cells[cellCoord.X][cellCoord.Y] != Cell.Dead)
               {
                   allIsDead = false;
                   break;
               }
           }
           if (allIsDead)
               return TurnsResult.Kill;

           return TurnsResult.Hit;
           
       }

       /// <summary>
       /// Вернуть количество клеток в стороне от заданной координатами x,y 
       /// сторона определяется смещением delta
       /// </summary>
       int ShipLineLength(Cell[][] cells, int x, int y, int deltaX, int deltaY)
       {
           int result = 0;
           while (true)
           {
               x += deltaX;
               y += deltaY;
               if (x >= cells.Length  || x < 0 || y >= cells[0].Length || y < 0 || cells[x][y] == Cell.Empty || cells[x][y] == Cell.Miss)
                   return result;
               result++;
           }
       }

       /// <summary>
       /// Вернуть количество ячеек у корабля с ячейкой с указанными координатами
       /// </summary>
       List<Point> GetShipCells(Cell[][] allCells, int x, int y)
       {
           Contract.Assert(allCells[x][y] != Cell.Empty && allCells[x][y] != Cell.Miss);

           int rightCount = ShipLineLength(allCells, x, y, 1, 0);//width max
           int leftCount = ShipLineLength(allCells, x, y, -1, 0);//width min
           int topCount = ShipLineLength(allCells, x, y, 0, 1);//height max
           int bottomCount = ShipLineLength(allCells, x, y, 0, -1);//height min

           //одна из 2 сторон будет нулевой или же обе в случае корабля длинной 1 ячейку
           //нужно добавить текущую клетку и тем самым учесть ее как часть корабля
           topCount++;
           rightCount++;

           var result = new List<Point>();

           for (int i = y-bottomCount; i < y+topCount; i++)
           {
               for (int j = x-leftCount; j < x+rightCount;j++)
               {
                   result.Add(new Point(j,i));//запишем все координаты корабля
               }
           }
           return result;

       }

       void MarkShipAsDead(Cell[][] cells, int x, int y)
       {
          var shipCellCoords =  GetShipCells(cells, x, y);

           Action<Cell, int, int> setCellIfPossible = (cellValue, xValue, yValue) =>
                                                          {
                                                              if (xValue >= 0 && xValue < cells.Length && yValue >= 0 && yValue < cells[0].Length)
                                                              cells[xValue][yValue] = cellValue;
                                                          }; 
           foreach (var c in shipCellCoords)
           {
               //заполняем miss'ами все пространство вокруг каждой точки, ячейки корабля восстановим ниже 

               setCellIfPossible(Cell.Miss, c.X + 1, c.Y);
               setCellIfPossible(Cell.Miss, c.X + 1, c.Y+1);
               setCellIfPossible(Cell.Miss, c.X + 1, c.Y-1);

               setCellIfPossible(Cell.Miss, c.X, c.Y+1);
               setCellIfPossible(Cell.Miss, c.X, c.Y-1);

               setCellIfPossible(Cell.Miss, c.X-1, c.Y);
               setCellIfPossible(Cell.Miss, c.X-1, c.Y+1);
               setCellIfPossible(Cell.Miss, c.X-1, c.Y-1);
           }

           foreach (var c in shipCellCoords)
           {
               cells[c.X][c.Y] = Cell.Dead;
           }
       }





        void ResetGame()
        {

            SetGameStatus(GameStatus.Ready);

            for (int i = 0; i < Model.Current.Length; i++)
            {
                for (int j = 0; j < Model.Current[0].Length; j++)
                {
                    Model.Current[i][j] = Cell.Empty;
                    Model.Enemy[i][j] = Cell.Empty;
                }
            }
            Worker.Reset();


            RecountReadyShips(Model.Current, out Model.CurrentShips);
            UpdateShipsLabels(Model.CurrentShips);

            CurrentBackground.Invalidate();
            EnemyBackground.Invalidate();
        }

       void SetGameStatus(GameStatus newStatus)
       {
          if (Model.Status != newStatus)
          {
              Model.Status = newStatus;
              UpdateLabelsByStatus(newStatus);
              if (newStatus == GameStatus.Ready)
                  ResetGame();
          }
       }




    }
}
