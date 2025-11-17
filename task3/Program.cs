using System;

class Program
{
    static void Main(string[] args)
    {
        Parameter demo = new Parameter();

        int value = 5;
        demo.Increase(ref value);
        Console.WriteLine("After Increase: " + value);

        demo.GetFullName(out string myName);
        Console.WriteLine("Full Name: " + myName);

        int result = demo.SumAll(10, 20, 30, 40);
        Console.WriteLine("Sum of all: " + result);
    }
}
