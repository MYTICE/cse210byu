using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string name = GetName();
        int number = GetNumber();

        int squared = GetSquared(number);

        DisplayResult(name, squared);

    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string GetName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        return name;
    }
    static int GetNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int GetSquared(int number)
    {
        int squared = number * number;

        return squared;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}.");
    }
}