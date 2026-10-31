using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a number (0 to quit):");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;
        foreach (int value in numbers)
        {
            sum += value;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int value in numbers)
        {
            if (value > max)
            {
                max = value;
            }
        }
        Console.WriteLine($"The maximum is: {max}");
    }
}