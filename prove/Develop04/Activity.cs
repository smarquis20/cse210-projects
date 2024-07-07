public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Get ready...");
        ShowSpinner(4);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(6);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(6);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        for(int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(125);
            Console.Write("\b-");
            Thread.Sleep(125);
            Console.Write("\b\\");
            Thread.Sleep(125);
            Console.Write("\b|");
            Thread.Sleep(125);
            Console.Write("\b \b");
        }
    }

    // 
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}