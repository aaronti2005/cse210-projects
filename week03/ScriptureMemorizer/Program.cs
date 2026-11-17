// SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS:
// Add a loop, along with `if` validations, to ensure that the random numbers used to select a word to hide do not pick a word that is already hidden.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        while (userInput != "quit" && userInput != "Quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            if (userInput != "quit" && userInput != "Quit")
            {
                scripture.HideRandomWords(3);
            }

        }

    }
}