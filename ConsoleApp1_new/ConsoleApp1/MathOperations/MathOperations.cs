using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathOperations
    {
        public void AdditionSubtractionOperation(ref List<double> listOfNumbers, ref List<string> listOfMathematicalOperations)
        {
            for (int i = 0; i < listOfMathematicalOperations.Count; i++)
            {
                if (listOfMathematicalOperations[i].Equals("+"))
                {
                    double result = listOfNumbers[i] + listOfNumbers[i + 1];
                    listOfNumbers[i] = result;
                    listOfNumbers.RemoveAt(i + 1);
                    listOfMathematicalOperations.RemoveAt(i);
                    i--;
                }
                else
                     if (listOfMathematicalOperations[i].Equals("-"))
                {
                    double result = listOfNumbers[i] - listOfNumbers[i + 1];
                    listOfNumbers[i] = result;
                    listOfNumbers.RemoveAt(i + 1);
                    listOfMathematicalOperations.RemoveAt(i);
                    i--;
                }
            }
        }       

        public void MultiplicationDivisionOperation(ref List<double> listOfNumbers, ref List<string> listOfMathematicalOperations)
        {
            for (int i = 0; i < listOfMathematicalOperations.Count; i++)
            {
                if (listOfMathematicalOperations[i].Equals("*"))
                {
                    double result = listOfNumbers[i] * listOfNumbers[i + 1];
                    listOfNumbers[i] = result;
                    listOfNumbers.RemoveAt(i + 1);
                    listOfMathematicalOperations.RemoveAt(i);
                    i--;
                }
                else
                    if (listOfMathematicalOperations[i].Equals("/"))
                {
                    double result = listOfNumbers[i] / listOfNumbers[i + 1];
                    listOfNumbers[i] = Math.Round(result, Constants.mathRound);
                    listOfNumbers.RemoveAt(i + 1);
                    listOfMathematicalOperations.RemoveAt(i);
                    i--;
                }
            }
        }

    }
}
