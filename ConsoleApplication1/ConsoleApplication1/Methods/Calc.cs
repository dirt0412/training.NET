using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Methods
{
    public class Calc
    {
        /// <summary>
        /// metoda sprawdzajaca czy liczba jest parzysta
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckNumberParity(int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }

        /// <summary>
        /// metoda sprawdzajaca czy liczba jest parzysta
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool CheckNumberParity1(int number)
        {
            return (number % 2 == 0 ? true : false);           
        }

    }
}
