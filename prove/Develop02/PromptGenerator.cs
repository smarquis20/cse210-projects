public class PromptGenerator
    {
        // List that holds all of the questions that will be asked by the journal program.
        public List<string> _prompts = new List<string>{"What was the most challenging aspect of your day today? How did you handle it, and what did you learn from the experience?","What are three things you are grateful for right now?  Why are these things important to you?","What progress did you make towards your goals today?  What steps did you take, and how do you feel about your progress?","Describe a recent experience or conversation that made you think differently about yourself or the world around you.","Reflect on your daily habits and routines. Which habits served you well today, and which ones do you feel could be improved?","What made you happy today and why?","What changes occured in your life today? How did you feel about it?"};

        // random class that will provide the random number for prompt index
        static Random rnd = new Random();
        
        // random int variable that picks the random number for the prompt index
        int randNumber = rnd.Next(7);

        // function that takes a random number and picks a prompt at random. Returns the string question from the above list
        public string GetRandomPrompt()
            {
                string randomQuestion = _prompts[randNumber];
                return randomQuestion;
            }
    }