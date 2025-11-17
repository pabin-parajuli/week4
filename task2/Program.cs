using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        calc.PrintWelcome();

        int sum = calc.Add(10, 20);
        Console.WriteLine("Addition: " + sum);

        int mul1 = calc.Multiply(5, 3);
        Console.WriteLine("Multiply (5,3): " + mul1);

        int mul2 = calc.Multiply(7);
        Console.WriteLine("Multiply (7): " + mul2);
    }
}
