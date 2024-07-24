public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public double GetCycleSpeed()
    {
        return _speed;
    }

    public void SetCycleSpeed(double speed)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (GetLength() / 60.0d);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0d / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}