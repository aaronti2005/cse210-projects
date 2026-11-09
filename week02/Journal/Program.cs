// SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS:
// Added a feature to capture and save the user's emotional state (Mood) for each journal entry, which is also saved to and loaded from the file.
// Improved the loading process by checking if the file exists using File.Exists() before trying to read it, preventing program crashes.

using System;

class Program
{
    static void Main(string[] args)
    {
        int function = 0;
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        

        while (function != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string functionChoice = Console.ReadLine();
            function = int.Parse(functionChoice);

            if (function == 1)
            {
                string RandomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(RandomPrompt);
                
                Console.Write("> ");
                string userText = Console.ReadLine();

                Console.WriteLine("How did you feel today? ");
                string usermood = Console.ReadLine();
                
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();            
                
                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._prompText = RandomPrompt;
                newEntry._entryText = userText;
                newEntry._mood = usermood;

                theJournal.AddEntry(newEntry);
            }

            if (function == 2)
            {
                theJournal.DisplayAll();
            }

            if (function == 3)
            {
                Console.WriteLine("What is the file name? ");
                string file = Console.ReadLine();
                
                if (File.Exists(file))
                {
                    theJournal.LoadFromFile(file);   
                }
                else
                {
                    Console.WriteLine("The file does not exist. Please write and save a journal first.");
                    Console.WriteLine(" ");
                }
            
            }

            if (function == 4)
            {
                Console.WriteLine("What is the file name? ");
                string file = Console.ReadLine();

                theJournal.SaveToFile(file);    
            }
        }
        
        
    }
}