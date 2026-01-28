class Entry
{
    public string _date;
    public string _entry;
    public string _title;
    public string _prompt;
    // metheds
    public void OutputEntry()
    {
        Console.WriteLine($"[{_date}]");
    }
}