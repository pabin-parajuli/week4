using System;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();

        s1.name = "Prabin";
        s1.age = 20;
        s1.address = "Pokhara";

        s2.name = "Aayush";
        s2.age = 21;
        s2.address = "Kathmandu";

        Console.WriteLine("=== Student 1 ===");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Address: " + s1.address);

        Console.WriteLine("\n=== Student 2 ===");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Address: " + s2.address);

        Console.WriteLine("\nCollege Name (Static Field): " + Student.collegeName);
    }
}
