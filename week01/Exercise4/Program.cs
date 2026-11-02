using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int inputN = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (inputN != 0)
        {
            Console.Write("Enter number: ");
            string inputNum = Console.ReadLine();  
            inputN = int.Parse(inputNum);

            if (inputN != 0)
            {
                numbers.Add(inputN);
            }
        }
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        } 
        Console.WriteLine($"The sum is: {total}");
        
        int count = numbers.Count;
        float average = (float)total / count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max=number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}