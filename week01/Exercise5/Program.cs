using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int squarenum = SquareNumber(number);
        
        DisplayResult(squarenum, name);        
    }
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int favnum = int.Parse(num);
        return favnum; 
    } 

    static int SquareNumber(int number)
    {
        int square = number*number;
        return square; 
    } 
    
    static void DisplayResult(int squarenum, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squarenum}");    
    }

    
}