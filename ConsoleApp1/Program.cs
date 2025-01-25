namespace Kalkulator
{
    public class Program
    {
        public static void Main()
        {
        Console.WriteLine("Kalkulator konsolowy, wpisz dwie liczby i operację, którą chcesz wykonać");
        Console.WriteLine("Enter aby pokazać wynik, Esc aby zakończyć");


        int result = 0;
        string operacja = "";
        int a = 0;
        int b = 0;

        while (true)
            {
            try 
                {
                    Console.WriteLine("Podaj pierwszą liczbę");
                    a = int.Parse(Console.ReadLine());
                    result += a;

                    Console.WriteLine("Podaj operację");
                    operacja = Console.ReadLine();

                    Console.WriteLine("Podaj drugą liczbę");
                    b = int.Parse(Console.ReadLine());
                }
            catch (Exception e)
                {
                    Console.WriteLine("Niepoprawna wartość");
                    continue;
                }
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (operacja == "+")
                {
                    Operacje.dodaj(a, b);
                    Console.WriteLine(result);
                }
                 else if (operacja == "-")
                {
                    Operacje.odejmij(a, b);
                    Console.WriteLine(result);
                }
                 else if (operacja == "*")
                {
                    Operacje.pomnoz(a, b);
                    Console.WriteLine(result);
                }
                 else if (operacja == "/")
                {
                    Operacje.podziel(a, b);
                    Console.WriteLine(result);
                }
                 else if (operacja == "%")
                {
                    Operacje.procent(a, b);
                    Console.WriteLine(result);
                }
                else 
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}