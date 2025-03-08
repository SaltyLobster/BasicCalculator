
namespace ConsoleApp1
{
    public class InputInterface
    {
        public static (double firstNum, double secondNum, string opertion) ValueInput(bool skipA, double firstNum)
        {
            if (skipA)
            {
                string operation = OperationInput(firstNum);
                double secondNum = NumberInput(firstNum, operation);
                return (firstNum, secondNum, operation);
            }
            else
            {
                firstNum = NumberInput();
                string operation = OperationInput(firstNum);
                double secondNum = NumberInput(firstNum, operation);
                return (firstNum, secondNum, operation);

            }
        }

        private static double NumberInput()
        {
            double number;
            Console.WriteLine("Enter the number:");
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect value! \nEnter the number:");
                    continue;
                }
            }
            return number;
        }

        private static double NumberInput(double firstNum, string operation)
        {
            double number;
            Console.WriteLine($"{firstNum} {operation}\nEnter the number:");
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{firstNum} {operation}\nIncorrect value! \nEnter the number:");
                    continue;
                }
            }
            return number;
        }

        private static string OperationInput(double firstNum)
        {
            string operation;
            Console.WriteLine($"{firstNum}\nEnter one of the operations (+, -, *, /, %)");

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
                    Console.WriteLine($"{firstNum}\nIncorrect value! \nEnter one of the operations (+, -, *, /, %)");
                    continue;
                }
            }
            return operation;
        }
    }
}

