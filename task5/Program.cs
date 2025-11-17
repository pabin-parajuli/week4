using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day (e.g., Sunday): ");
        string day = Console.ReadLine();

        DayType dayType;

        if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine($"It is: {dayType}");
        Console.WriteLine();

        Book book1 = new Book("C# Basics", "John Doe", 29.99);

        Book book2 = book1 with { title = "Advanced C#", price = 49.99 };

        Console.WriteLine("First Book:");
        Console.WriteLine(book1);

        var (title, author, price) = book2;
        Console.WriteLine("\nSecond Book Deconstructed:");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}
