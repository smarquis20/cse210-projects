public class Entry
    {
        // string that holds today's date
        public string _date;

        // string that holds the random journal question
        public string _promptString;

        // string that holds the users journal entry
        public string _entryText;

        //Entry function that will display an entry in a formated style
        public void Display()
            {
                Console.WriteLine($"Date: {_date} - Prompt: {_promptString}");
                Console.WriteLine($"{_entryText}");
                Console.WriteLine("");
            }

    }