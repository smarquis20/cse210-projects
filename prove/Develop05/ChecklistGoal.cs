public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;   
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string completionStatus;

        if(IsComplete())
        {
            completionStatus = "X";
        }
        else
        {
            completionStatus = " ";
        }

        string detailString = $"[{completionStatus}] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";

        return detailString;
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public int GetBonusPoints()
    {
        if (IsComplete())
        {
            return _bonus;
        }
        else
        {
            return 0;
        }
    }
}