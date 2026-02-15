using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Scriptres scripture = new Scriptres();
        string quit = "";

        while (quit != "quit")
        {
            Console.Clear();
            scripture.Display();

            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            quit = Console.ReadLine();
            
            if (quit != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine();
    }
}