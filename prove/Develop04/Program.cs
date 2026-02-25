using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Develop04 World!");

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        Console.Write("\nHow long do you want to go for? ");
        string seconds = Console.ReadLine();
        int t = int.Parse(seconds);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(t);

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

        Console.WriteLine("\nDone.\n");
    }   
}