using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputInterface
    {
        public static (double, double, double, string) ValueInput()
        {
            double a = 0;
            double b = 0;
            double result = 0;
            string operation = "";
            string input;

            Console.Clear();
            Console.WriteLine("Enter the first number:");
            while (true)
            {
                input = Console.ReadLine();
                if (double.TryParse(input, out a))
                {
                    result += a;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect value! \nEnter a first number:");
                    continue;
                }
            }

            Console.WriteLine($"{result}\nEnter one of the operations (+, -, *, /, %)");
            while (true)
            {
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{result}\nIncorrect value! \nEnter one of the operations (+, -, *, /, %)");
                    continue;
                }
            }
            
            Console.WriteLine($"{result} {operation}\nEnter the second number:");
            while (true)
            {
                input = Console.ReadLine();
                if (double.TryParse(input, out b))
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {operation}\nIncorrect value! \nEnter a second number:");
                    continue;
                }
            }
            return (a, b, result, operation);
        }
    }
}

