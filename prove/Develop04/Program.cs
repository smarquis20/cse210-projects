// For extra credit I added an algorithm that shuffles the indexes of the questions so that the same question is not used
// twice.  Its called the fisher yates shuffle algorithm.  This was done in the ReflectingActivity.cs getRandomQuestion section.
using System;

class Program
{
    static void Main(string[] args)
    {
       while (true)
       {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    BreathingActivity breathe = new BreathingActivity();
                    breathe.Run();
                    break;
                case 2:
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.Run();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Thank you for being mindfull.");
                    Console.WriteLine();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please choose 1 - 4.");
                    break;
            }
       }
    }
}