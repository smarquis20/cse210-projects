using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        string userInput = "";
        int userGuess = 0;
        do
        {
            Console.Write("What is the magic number? ");
            userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (number > userGuess)
            {
                Console.WriteLine("Higher");
            }

            else if (number < userGuess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        while (userGuess != number);

    }
}