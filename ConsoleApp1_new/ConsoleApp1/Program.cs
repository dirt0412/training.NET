using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        MathOperations mathOperations = new MathOperations();
        List<double> listOfNumbers = new List<double>();
        List<string> listOfMathematicalOperations = new List<string>();    

        static void Main(string[] args)
        {
            Program p = new Program();
            string inputString = string.Empty;


            Console.Write("Enter data: ");
            inputString = Console.ReadLine();

            string result = p.Calculate(inputString);
            Console.Write(result);

            Console.ReadKey();
        }

        public string Calculate(string inputString)
        {
            List<string> allSymbols = Common.getAllChars(inputString);

            if (Common.Validate(allSymbols, ref listOfNumbers, ref listOfMathematicalOperations))
            {
                mathOperations.MultiplicationDivisionOperation(ref listOfNumbers, ref listOfMathematicalOperations);

                mathOperations.AdditionSubtractionOperation(ref listOfNumbers, ref listOfMathematicalOperations);

                return "result: " + listOfNumbers.FirstOrDefault();
            }
            else
                return "enter correct data";


        }



    }
}
