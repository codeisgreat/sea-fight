using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaFight
{
   public static class Utils
    {
        /// <summary>
        /// вернет является ли строка числом
        /// </summary>
       public static bool IsNum(string message)
        {
            int num;
            return int.TryParse(message, out num);
        }
    }
}
