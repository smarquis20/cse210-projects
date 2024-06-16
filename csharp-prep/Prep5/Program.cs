using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int sqrtNum = SquareNumber(favNum);
        DisplayResult(name,sqrtNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int userFavNum = int.Parse(userInput);
        return userFavNum;
    }

    static int SquareNumber(int favNum)
    {
        int squareNum = favNum * favNum;
        return squareNum;
    }

    static void DisplayResult(string userName, int sqrt)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrt}");
    }
}