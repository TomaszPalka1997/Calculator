using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w Kalulatorze!");
            while (true)
            {
                
                try
                {
                    while (true)
                    {
                        Console.WriteLine("podaj pierwsza liczbne");
                        var number1 = GetInput();

                        Console.WriteLine("podaj dzialanie: '+', '-', '*', '/'");
                        var operation = Console.ReadLine();

                        Console.WriteLine("podaj druga liczbne");
                        var number2 = GetInput();

                        int result = Calculate(number1, number2, operation);

                        Console.WriteLine($"wynik: {result}");

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static int GetInput()
        {
            if (int.TryParse(Console.ReadLine(), out int input))
                return input;
            else
                throw new Exception("Podana wartosc nie jest liczba");
        }

        private static int Calculate(int number1, int number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("zly znak operacji");

            }
        }
    }
}