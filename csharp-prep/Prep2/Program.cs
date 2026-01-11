using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat is your grade? ");
        string total = Console.ReadLine();
        int score = int.Parse(total);
        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (score >= 70)
        {
            Console.WriteLine($"Your grade is {letter}. You pass! Good job!\n");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}. You fail. Sorry.\n");
        }

    }
}