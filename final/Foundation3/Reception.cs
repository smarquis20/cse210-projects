public class Reception : Event
{
    private List<string> _rsvpName;

    public Reception(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _rsvpName = new List<string>();
    }

    public void AddRsvpName(string rsvpName)
    {
        _rsvpName.Add(rsvpName);
    }

    public override string GetFullDetails()
    {
        string rsvpNames = string.Join(", ",_rsvpName);
        return $"{GetStandardDetails()}\nEvent Type: Recption\nRSVP Name: {rsvpNames}";
    }
}