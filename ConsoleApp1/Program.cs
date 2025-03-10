﻿using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    var (a, b, result, operation) = InputInterface.ValueInput();
                    Calculating.Calculate(a, b, ref result, operation);

                    Console.Clear();
                    Console.WriteLine($"Wynik: {result}");
                    Console.WriteLine("Press any button to start again or Esc to Close");

                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press any button to start again or Esc to Close");

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
