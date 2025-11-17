using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player();
        Console.WriteLine("Player 1 Details:");
        Console.WriteLine($"Name: {player1.playerName}");
        Console.WriteLine($"Level: {player1.level}");
        Console.WriteLine($"Health: {player1.health}");
        Console.WriteLine();

        Player player2 = new Player("John", 5, 100);
        Console.WriteLine("Player 2 Details:");
        Console.WriteLine($"Name: {player2.playerName}");
        Console.WriteLine($"Level: {player2.level}");
        Console.WriteLine($"Health: {player2.health}");
    }
}
