namespace Kalkulator
{
    public class Program
    {
        public static void Main()
        {
            double result = 0;
            string operacja = "";
            double a = 0;
            double b = 0;
            bool firstIteration = true;

            while (true)
            {
                try
                {
                    Console.WriteLine("Kalkulator konsolowy!");
                    Console.WriteLine("Podaj pierwszą liczbę.");
                    if (firstIteration)
                    {
                        try
                        {
                            a = double.Parse(Console.ReadLine());
                            result += a;
                            firstIteration = false;
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Niepoprawna wartość!\n Wpisz nową liczbę.");
                            Console.WriteLine();
                            continue;
                        }
                    }
                    else
                    {
                        a = result;
                    }
                    
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Podaj operację: +, -, *, /, %\n{a}");
                        operacja = Console.ReadLine();
                        if (operacja == "+" || operacja == "-" || operacja == "*" || operacja == "/" || operacja == "%")
                        {
                            Console.Clear();
                            Console.WriteLine($"Podaj drugą liczbę \n{a} {operacja}");
                            while (true)
                            {
                                try
                                {
                                    b = double.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Niepoprawna wartość\n Podaj drugą liczbę\n{a} {operacja}");
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Niepoprawna operacja. Wciśnij Enter aby spróbować jeszcze raz");
                            Console.ReadLine();
                            continue;
                        };
                    }
                    if (operacja == "+")
                    {
                        Console.Clear();
                        result = Operacje.dodaj(a, b);
                    }
                    else if (operacja == "-")
                    {
                        Console.Clear();
                        result = Operacje.odejmij(a, b);
                    }
                    else if (operacja == "*")
                    {
                        Console.Clear();
                        result = Operacje.pomnoz(a, b);
                    }
                    else if (operacja == "/")
                    {
                        if (b == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nie można dzielić przez 0");
                            continue;
                        }
                        Console.Clear();
                        result = Operacje.podziel(a, b);
                    }
                    else if (operacja == "%")
                    {
                        Console.Clear();
                        result = Operacje.procent(a, b);
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Niepoprawna wartość\n Wpisz nową liczbę");
                    Console.WriteLine();
                    continue;
                }
                Console.Clear();
                Console.WriteLine($"Wynik: {result}");
                Console.WriteLine("Naciśnij Enter, aby kontynuować, Esc aby zakończyć, Del aby zresetować");

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    continue;
                }
                else if (key.Key == ConsoleKey.Delete)
                {
                    result = 0;
                    firstIteration = true;
                    Console.Clear();
                    continue;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}