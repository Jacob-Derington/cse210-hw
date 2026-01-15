using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("\nWhat is the magic number? ");
        // string num = Console.ReadLine();
        // int n = int.Parse(num);

        Random randomGenerator = new Random();
        int n = randomGenerator.Next(1, 101);

        Console.Write("\nWhat is your guess? ");
        string guess = Console.ReadLine();
        int g = int.Parse(guess);

        while (g != n)
        {
            if (g < n)
            {
                Console.WriteLine("Higher");
            }
            else if (g > n)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            g = int.Parse(guess);
        }

        Console.WriteLine("You guessed it!\n");
    }
}