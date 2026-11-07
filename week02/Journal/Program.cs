using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Journal theJournal = new Journal();
        Random random = new Random();



        int _userInput = 0;
        while (_userInput != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out _userInput))
                if (_userInput == 1)
                {
                    int index = random.Next(prompts.Count);
                    string selectedPrompt = prompts[index];

                    Console.WriteLine(selectedPrompt);
                    Console.Write("> ");
                    string userResponse = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString();
                    newEntry._prompt = selectedPrompt;
                    newEntry._response = userResponse;

                    theJournal.AddEntry(newEntry);

                    Console.WriteLine("Your response has been recorded.");
                }
                else if (_userInput == 2)
                {
                    Console.WriteLine("Displaying your journal entries.");
                    theJournal.DisplayJournal();
                    Console.WriteLine();
                }
                else if (_userInput == 3)
                {
                    Console.WriteLine("Please enter the filename to load from:");
                    string filename = Console.ReadLine();
                    theJournal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded successfully!\n");
                }
                else if (_userInput == 4)
                {
                    Console.WriteLine("What is the filename to save to?");
                    string filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                    Console.WriteLine("Journal saved successfully!\n");
                }
                else if (_userInput == 5)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }
        }
    }
}