using System;
public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void displayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
}