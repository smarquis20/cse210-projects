using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";

        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
    
        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine($"You passed the class. Congratulations!");
        }
        else
        {
            Console.WriteLine($"You failed the class. Try harder next time.");
        }

    }
}