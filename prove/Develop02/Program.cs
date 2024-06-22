using System;

// Extra credit i saved the data to a mysql database and load from that database
// found example on https://www.c-sharpcorner.com/UploadFile/8af3e0/connecting-to-mysql-using-C-Sharp-net/
// and https://stackoverflow.com/questions/8326905/c-sharp-foreach-with-mysql
class Program
{
    static void Main(string[] args)
    {
        int menuOption = 0;

        // Creates a new Journal object
        Journal newJournal = new Journal();

        // Gets the current date in the mm/dd/yyyy format and saves it to a variable
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        // Basic menu which will loop forever till the user types 5
        while (menuOption != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            menuOption = int.Parse(userInput);

            // if statements corrispond with menu options, option 1 will create a new entry, grab a random question, and ask the user to input their response and will add it to the entry list.
            if (menuOption == 1)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = dateText;

                    PromptGenerator newPrompt = new PromptGenerator();
                    string newQuestion = newPrompt.GetRandomPrompt();
                    newEntry._promptString = newQuestion;

                    Console.WriteLine(newQuestion);
                    Console.Write("> ");
                    userInput = Console.ReadLine();
                    newEntry._entryText = userInput;

                    newJournal.AddEntry(newEntry);
                }
            // Option 2 will display all dates, questions, and responses entered so far.
            else if (menuOption == 2)
                {
                    newJournal.DisplayAll();
                }
            // Option 3 will save all responses in the entries list to a user specified file
            else if (menuOption == 3)
                {
                    Console.Write("Please enter database name: ");
                    string userFileName = Console.ReadLine();

                    newJournal.SaveToFile(userFileName);

                    Console.WriteLine($"\nYour journal has been saved to the {userFileName} database.\n");
                }
            // Option 4 will load all response from a user specified file and create new entries in the current open journal
            else if (menuOption == 4)
                {
                    Console.Write("Please enter database name: ");
                    string userFileName = Console.ReadLine();

                    newJournal.LoadFromFile(userFileName);

                    Console.WriteLine($"\nEntries has been loaded from the {userFileName} database.\n");
                }
            
        }
    }
}