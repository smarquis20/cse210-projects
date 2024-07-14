public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu option.");
                        break;
                }
        }    
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalDetails()
    {
        int goalNum = 1;
        foreach(var goal in _goals)
        {
            Console.WriteLine($"{goalNum}. {goal.GetDetailsString()}");
            goalNum++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        int goalNumber = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalNumber)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("That is an Invalid goal type.");
                break;
        }

    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > _goals.Count())
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }
        
        var goal = _goals[goalNumber - 1];
        goal.RecordEvent();
        int earnedPoints = goal.GetPoints();
        _score += goal.GetPoints();

        if (goal is ChecklistGoal checklistGoal)
        {
            _score += checklistGoal.GetBonusPoints();
        }
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

            Console.WriteLine();
            Console.WriteLine("Goals saved successfully!");
            Console.WriteLine();
        }

    }

    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] goalType = lines[i].Split(":");
            string[] goalItem = goalType[1].Split("|");

            switch (goalType[0])
            {
                case "SimpleGoal":
                    string name = goalItem[0];
                    string description = goalItem[1];
                    int points = int.Parse(goalItem[2]);
                    bool isComplete = bool.Parse(goalItem[3]);

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    simpleGoal.SetIsComplete(isComplete);

                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    name = goalItem[0];
                    description = goalItem[1];
                    points = int.Parse(goalItem[2]);

                    EternalGoal eternalGoal = new EternalGoal(name, description, points);

                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    name = goalItem[0];
                    description = goalItem[1];
                    points = int.Parse(goalItem[2]);
                    int target = int.Parse(goalItem[3]);
                    int bonus = int.Parse(goalItem[4]);
                    int amount = int.Parse(goalItem[5]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    checklistGoal.SetAmountCompleted(amount);

                    _goals.Add(checklistGoal);
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Goals loaded successfully.");
        Console.WriteLine();
    }
}