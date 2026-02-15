using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        string quit = "";

        while (quit != "quit")
        {
            Scriptres s1 = new Scriptres();
            s1.Display();
            Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
            quit = Console.ReadLine();
            
        }
        
        Console.WriteLine();
    }
}