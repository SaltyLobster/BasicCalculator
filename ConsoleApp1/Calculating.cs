using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculating
    {
        public static double Calculate(double a, double b, string operation)
        {
            double result;
            switch (operation)
            {
                case "+":
                    return result = a + b;
                case "-":
                    return result = a = b;

                case "*":
                    return result = a * b;
                case "/":
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Nie można dzielić przez 0");
                    }
                    else
                    {
                        return result = a / b;
                    }
                case "%":
                    return result = a * (b / 100);
                default:
                throw new InvalidOperationException("Nieznane działanie");
            }
        }
    }
}
