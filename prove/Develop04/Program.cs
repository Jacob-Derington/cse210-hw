using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello Develop04 World!");

        string c = "";
        while (c != "4")
        {
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice form the menu: ");
            c = Console.ReadLine();

        }

        // Activity activity = new Activity();

        Console.WriteLine("\nDone.\n");
    }   
}