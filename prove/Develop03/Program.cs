using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates the reference object and scripture object with provided data
        Reference scriptref1 = new Reference("James",1,22);
        Scripture newScript1 = new Scripture(scriptref1,"But be ye doers of the word, and not hearers only, deceiving your own selves.");
        
        Reference scriptref2 = new Reference("Proverbs",3,5,6);
        Scripture newScript2 = new Scripture(scriptref2,"Trust the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");

        // While loop will interact with the user to press enter to continue or quit to quit.  Will run
        // while there are still visable words and will stop when all words are hidden
        while(!newScript1.IsCompletelyHidden() | !newScript2.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(newScript1.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine(newScript2.GetDisplayText());
            Console.WriteLine("Press enter to hide words, or type 'quit' to stop.");
            string userInput = Console.ReadLine();

            if(userInput.ToLower() == "quit")
            {
                break;
            }

            // Call to hide random words from the scripture
            newScript1.HideRandomWords(3);
            newScript2.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(newScript1.GetDisplayText());
        Console.WriteLine(newScript2.GetDisplayText());

        if(newScript1.IsCompletelyHidden() && newScript2.IsCompletelyHidden())
        {
            Console.WriteLine("All the words are hidden. You are a scriptorian!");
        }
        else
        {
            Console.WriteLine("Thank you for memorizing scriptures. Come again!");
        }
    }
}