using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Common
    {
        public static List<string> getAllChars(string inputString)
        {
            List<string> symbols = new List<string>();
            StringBuilder sb = new StringBuilder();

            foreach (char c in inputString.Replace(" ", string.Empty))
            {
                if (Constants.mathematicalOperations.Contains(c.ToString()))
                {
                    if ((sb.Length > 0))
                    {
                        symbols.Add(sb.ToString());
                        sb.Length = 0;
                    }
                    symbols.Add(c.ToString());
                }
                else
                {
                    sb.Append(c);
                }
            }

            if ((sb.Length > 0))
            {
                symbols.Add(sb.ToString());
            }
            return symbols;
        }

        public static bool Validate(List<string> allSymbols, ref List<double> listOfNumbers, ref List<string> listOfMathematicalOperations)
        {
            double tempDouble;

            if (!Double.TryParse(allSymbols[allSymbols.Count - 1], out tempDouble))//last value must be number
                return false;

            for (int i = 0; i < allSymbols.Count; i++)
            {
              
                if (i % 2 != 0)
                {
                    if (Constants.mathematicalOperations.Contains(allSymbols[i]))
                        listOfMathematicalOperations.Add(allSymbols[i]);
                    else
                        return false;
                    if ((allSymbols[i] == "/" && allSymbols[i + 1] == "0"))//checked division by zero
                        return false;
                }
                else
                {
                    if (Double.TryParse(allSymbols[i], out tempDouble))
                        listOfNumbers.Add(tempDouble);
                    else
                        return false;
                }               
            }

            return true;
        }

    }
}
