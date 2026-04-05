class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetFullDetails()
    {
        return $"{GetShortDescription()}\nRSVP Email: {_email}";
    }

    public override string GetFull()
    {
        return $"{GetStandard()}\nType: Reception\nRSVP Email: {_email}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {_title} ({_date})";
    }
}