using System;


Console.WriteLine("Welcome in the Calculator!");
while (true)
{
    Console.WriteLine("flag");
    try
    {
        while (true)
        {
            Console.WriteLine("Type first number");
            var number1 = GetInput();

            Console.WriteLine("Type operation sign: '+', '-', '*', '/'");
            var operation = Console.ReadLine();

            Console.WriteLine("Type second number");
            var number2 = GetInput();

            float result = Calculate(number1, number2, operation);

            Console.WriteLine($"Result: {result}");

        }
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}


static float GetInput()
{
    if (float.TryParse(Console.ReadLine(), out float input))
        return input;
    else
        throw new Exception("Typed value is not a number");
}

static float Calculate(float number1, float number2, string operation)
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
            throw new Exception("Wrong operation sign");

    }
}
