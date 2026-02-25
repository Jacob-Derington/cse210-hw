class Activity
{
    protected int _duration;

    public void duration()
    {
        Console.Write("\nHow long do you want to go for? ");
        string seconds = Console.ReadLine();
        int _duration = int.Parse(seconds);

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
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}