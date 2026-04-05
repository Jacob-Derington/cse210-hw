class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFull()
    {
        return $"{GetStandard()}\nType: Outdoor\nExpected weather: {_weather}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Event: {_title} ({_date}), Weather: {_weather}";
    }
}