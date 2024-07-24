public class Swimming : Activity
{
    private int _numLap;

    public Swimming(string date, int length, int numLap) : base(date, length)
    {
        _numLap = numLap;
    }

    public int GetNumLap()
    {
        return _numLap;
    }

    public void SetNumLap(int numLap)
    {
        _numLap = numLap;
    }

    public override double GetDistance()
    {
        return _numLap * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetLength() / 60.0d);
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min): Distance {GetDistance()} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}