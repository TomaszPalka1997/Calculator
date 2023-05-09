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

                        float result = Calculate(number1, number2, operation);

                        Console.WriteLine($"wynik: {result}");

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static float GetInput()
        {
            if (float.TryParse(Console.ReadLine(), out float input))
                return input;
            else
                throw new Exception("Podana wartosc nie jest liczba");
        }

        private static float Calculate(float number1, float number2, string operation)
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