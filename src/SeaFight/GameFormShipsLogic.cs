using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeaFight
{
    public enum RecountStatus
    {
        Success,MoreThanFourLengthShip
    }

    public partial class GameForm : Form
    {
        //ships logic

        /// <summary>
        /// Метод для подсчета количества кораблей у игрока
        /// при расставлении кораблей перед игрой
        /// </summary>
        /// <param name="cells"></param>
        /// <param name="s"></param>
        RecountStatus RecountReadyShips(Cell[][] cells, out Ships s)
        {
            s = new Ships();
            //по умолчанию стоит максимальное количество кораблей каждого ранга, сравняем с реальным

            int nextShipLength = 0;

            //проходим по всем столбцам и строкам, так можно посчитать корабли длиннее 1
            //по строкам
            for (int i = 0; i < cells.Length; i++)     
            {
                for (int j = 0; j < cells[0].Length; j++)
                {
                    if (i != 0 && j == 0)
                    {
                        if (nextShipLength > 4)
                            return RecountStatus.MoreThanFourLengthShip;
                        if (nextShipLength > 1)
                            s.LengthCountShipsArray[nextShipLength]--;
                        nextShipLength = 0;
                    }

                    if (cells[i][j] == Cell.Life)
                        nextShipLength++;

                    if ((cells[i][j] != Cell.Life))
                    {
                        if (nextShipLength > 4)
                            return RecountStatus.MoreThanFourLengthShip;
                        if (nextShipLength > 1)
                            s.LengthCountShipsArray[nextShipLength]--;
                        nextShipLength = 0;
                    }
                }


            }
            if (nextShipLength > 1)
                s.LengthCountShipsArray[nextShipLength]--;
            nextShipLength = 0;
            //по столбцам
            for (int i = 0; i < cells.Length; i++)
            {
                
                for (int j = 0; j < cells[0].Length; j++)
                {
                    if (i != 0 && j == 0)
                    {
                        if (nextShipLength > 4)
                            return RecountStatus.MoreThanFourLengthShip;
                        if (nextShipLength > 1)
                            s.LengthCountShipsArray[nextShipLength]--;
                        nextShipLength = 0;
                    }

                    if (cells[j][i] == Cell.Life)
                        nextShipLength++;

                    if (cells[j][i] != Cell.Life)
                    {
                        if (nextShipLength > 4)
                            return RecountStatus.MoreThanFourLengthShip;
                        if (nextShipLength > 1)
                            s.LengthCountShipsArray[nextShipLength]--;
                        nextShipLength = 0;
                    }
                }
                
            }
            if (nextShipLength > 1)
                s.LengthCountShipsArray[nextShipLength]--;

            for (int i = 0; i < cells.Length; i++)
            {
                for (int j = 0; j < cells[0].Length; j++)
                {
                    if (cells[i][j] == Cell.Life && GetShipCells(cells, i, j).Count == 1)
                        //если корабль жив и его длина 1 ячейка..
                        s.LengthCountShipsArray[1]--;
                }
            }
            return RecountStatus.Success;

        }

        
        /// <summary>
        /// Метод для установки кораблей во время подготовки к игре
        /// устанавливает ячейку и возвращает true если по диагоналям в соседних клетках
        ///  нет кораблей и размер создающегося корабля не больше 4
        /// </summary>
        private bool TrySetupCell(Cell[][] cells, int x, int y)
        {
            cells[x][y] = Cell.Life;
            Ships outShip;
            bool noLongShips = RecountReadyShips(cells, out outShip) != RecountStatus.MoreThanFourLengthShip;
            bool rightTopEmpty = x == cells.Length - 1 || y == cells[0].Length - 1 || cells[x + 1][y + 1] == Cell.Empty;
            bool leftTopEmpty = x == cells.Length - 1 || y == 0 || cells[x + 1][y - 1] == Cell.Empty;
            bool rightBottomEmpty = x == 0 || y == cells[0].Length - 1 || cells[x - 1][y + 1] == Cell.Empty;
            bool leftBottomEmpty = x == 0 || y == 0 || cells[x - 1][y - 1] == Cell.Empty;
            if (noLongShips && rightBottomEmpty && leftBottomEmpty && rightTopEmpty && leftTopEmpty)
            {
                return true;
            }
            cells[x][y] = Cell.Empty;
            return false;
        }


    }

}
