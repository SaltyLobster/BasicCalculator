namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            double result = 0;
            double a = 0;
            string operation;
            double b = 0;
            bool firstIteration = true;
            
            Console.WriteLine("Kalkulator konsolowy!");
            Console.WriteLine("Podaj pierwszą liczbę.");

            while (true)
            {
                if (firstIteration)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out a))
                    {
                        result += a;
                        firstIteration = false;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Niepoprawna wartość!\n Wpisz liczbę.");
                        continue;
                    }
                }

                Console.WriteLine($"Podaj operację: +, -, *, /, %\n{a}");

                while (true)
                {
                    operation = Console.ReadLine();
                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%")
                    {
                        Console.Clear();
                        Console.WriteLine($"Podaj drugą liczbę. \n{a} {operation}");
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (double.TryParse(input, out b))
                            {
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"Niepoprawna wartość!\n Podaj drugą liczbę.\n{a} {operation}");
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Niepoprawna operacja. Wpisz operację: +, -, *, /, %");
                        continue;
                    }
                    ;
                }

                Calculate(ref a, ref b, ref result, operation);

                a = result;
                Console.Clear();
                Console.WriteLine($"Wynik: {result}");
                Console.WriteLine("Naciśnij Enter aby kontynuować, Esc aby zakończyć, R aby zresetować");

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    continue;
                }
                else if (key.Key == ConsoleKey.R)
                {
                    result = 0;
                    firstIteration = true;
                    Console.Clear();
                    Console.WriteLine("Kalkulator konsolowy!");
                    Console.WriteLine("Podaj pierwszą liczbę.");
                    continue;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        public static void Calculate(ref double a, ref double b, ref double result, string operation)
        {
            switch (operation)
            {
                case "+":
                    result = Operacje.dodaj(a, b);
                    break;
                case "-":
                    result = Operacje.odejmij(a, b);
                    break;
                case "*":
                    result = Operacje.pomnoz(a, b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Nie można dzielić przez 0");
                        break;
                    }
                    result = Operacje.podziel(a, b);
                    break;
                case "%":
                    result = Operacje.procent(a, b);
                    break;
            }
        }
    }
}
