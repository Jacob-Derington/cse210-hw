class Activity
{
    protected int _duration;
    protected string _name;
    protected string _description;

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);

        Console.Write("\nHow long do you want to go for? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nPrepare to begin... ");
        Spinner(5);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        Spinner(5);

        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
        Spinner(5);
    }

    protected void Spinner(int seconds)
    {
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add(")");
        animationStrings.Add("}");
        animationStrings.Add(")");
        animationStrings.Add("|");
        animationStrings.Add("(");
        animationStrings.Add("{");
        animationStrings.Add("(");        

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}