using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            double firstNum = 0;
            bool skipA = false;

            while (true)
            {
                try
                {
                    Console.Clear();

                    var (newFirstNum, secondNum, operation) = InputInterface.ValueInput(skipA, firstNum);
                    double result = Calculating.Calculate(newFirstNum, secondNum, operation);

                    Console.Clear();
                    Console.WriteLine($"Wynik: {result}");
                    Console.WriteLine("Press any button to continue, R to reset or Esc to Close");

                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    else if (key.Key == ConsoleKey.R)
                    {
                        firstNum = 0;
                        skipA = false;
                    }
                    else
                    {
                        firstNum = result;
                        skipA = true;
                    }
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press any button to reset or Esc to Close");

                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    continue;
                }
            }
        }
    }
}
