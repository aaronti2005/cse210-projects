using System;

public class Entry
{
    public string _date;
    public string _prompText;
    public string _entryText;

    public string _mood;
    public void Display()
    {
       Console.WriteLine($"Date: {_date} - Prompt: {_prompText}");
       Console.WriteLine(_entryText);
       Console.WriteLine($"Mood today: {_mood}");
       Console.WriteLine(" ");
    }
}
