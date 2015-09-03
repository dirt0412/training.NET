using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Methods
{
    public class Calc
    {
        public static bool CheckNumberParity(int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }
    }
}
