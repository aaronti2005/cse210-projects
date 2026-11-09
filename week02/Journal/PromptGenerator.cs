using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("What is one thing you accomplished today that made you feel proud?");
        _prompts.Add("Who made you laugh or smile today, and what did they do?");
        _prompts.Add("What was the most challenging moment today, and how did you handle it?");
        _prompts.Add("How many friends were you able to talk to in person today?");
        _prompts.Add("What is one thing you did today that you want to improve tomorrow?");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        return _prompts[number];

    }
}
