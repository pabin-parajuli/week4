using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for input
        Console.Write("Enter marks: ");
        string marksInput = Console.ReadLine();
        Console.Write("Enter total: ");
        string totalInput = Console.ReadLine();

        // Convert input safely using TryParse
        if (int.TryParse(marksInput, out int marks) && int.TryParse(totalInput, out int total))
        {

            // ERROR: marks / total does integer division, result will be wrong
            // FIX: Cast to double to get correct floating-point division
            double percentage = (double)marks / total * 100;

            Console.WriteLine($"Percentage: {percentage}%");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
        }
    }
}
