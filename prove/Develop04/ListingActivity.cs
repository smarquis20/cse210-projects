public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count());
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime start = DateTime.Now;
        DateTime endTime = start.AddSeconds(_duration);
        List<string> inputList = new List<string>();

        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            inputList.Add(Console.ReadLine());
        }

        _count = inputList.Count();

        Console.WriteLine($"You listed {_count} items.");
        Console.WriteLine();
        DisplayEndingMessage();


    }
}