class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n\nBreath in...");
            Countdown(4);

            Console.WriteLine("\nBreath out...");
            Countdown(4);
        }

        EndMessage();
    }
}