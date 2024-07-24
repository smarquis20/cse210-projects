public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public double GetRunDistance()
    {
        return _distance;
    }

    public void SetRunDistance(double distance)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetLength()) * 60d;
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}