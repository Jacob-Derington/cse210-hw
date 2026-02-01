class Entry
{
    public string _date;
    public string _entry;
    public string _prompt;

    public void OutputEntry()
    {
        Console.WriteLine($"Date: [{_date}]");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine();

    }
}