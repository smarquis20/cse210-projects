public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private Random _rand;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _rand = new Random();

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    }
    public string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count());
        
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        for (int i = _questions.Count() - 1; i > 0; i--)
        {
            int ranIndex = _rand.Next(i + 1);

            string temp = _questions[i];
            _questions[i] = _questions[ranIndex];
            _questions[ranIndex] = temp;
        }
        
        return _questions[0];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(8);
        Console.Clear();

        DateTime start = DateTime.Now;
        DateTime endTime = start.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(15);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndingMessage();

    }
}