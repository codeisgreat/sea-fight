using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SeaFight
{
    public enum Cell
    {
        Empty, Life, Dead, Miss
    }
    public enum GameStatus
    {
        None,//по умолчанию
        Ready,//подготовка к игре, раставление кораблей 
        InGameWait,//игра с соперником, ожидание хода
        InGameTurn //игра с соперником, ход
    }
    public enum TurnsResult
    {
        Miss=0,
        Hit=1,
        Kill=2
    }

    public class Ships
    {

        /// <summary>
        /// словарь с ключем - длиной корабля, значением - 
        /// </summary>
        public Dictionary<int, int> LengthCountShipsArray;

        public Ships()
        {
            LengthCountShipsArray = new Dictionary<int, int> { { 1, 4 }, { 2, 3 }, { 3, 2 }, { 4, 1 } };
        }

        public bool Filled()
        {
            return LengthCountShipsArray.Any(ship => ship.Value == 0);
        }

    }


    public static class Model
    {
        public static Cell[][] Current = new Cell[10][];
        public static Cell[][] Enemy = new Cell[10][];

        public static Ships CurrentShips = new Ships();
        public static Ships EnemyShips = new Ships();

        public static GameStatus Status = GameStatus.None;

        /// <summary>
        /// Результат последнего хода противника. Попал-не попал - убил ли он корабль
        /// </summary>
       // public static TurnsResult LastResultOnCurrent = 0;

        /// <summary>
        /// Координаты ячейки в  виде (0..9,0..9) которые должны отправиться противнику
        /// </summary>
       public static Point LastCurrentCoords = new Point();


        public static string CurrentNick;
        public static string EnemyNick;

        static Model()
        {
            //инициализация ячеек при старте программы
            for (int i = 0; i < Current.Length; i++)
            {
                Current[i] = new Cell[10];
                Enemy[i] = new Cell[10];
            }
        }
    }
}
