using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine("\nWelcome to the journal program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("what sould you like to do? ");
        string choices = Console.ReadLine();
        int c = int.Parse(choices);

        if (c == 1)
        {
            
        }
        else if (c == 3)
        {
            Entry entry = new Entry();
            entry._date = dateText;
            entry.OutputEntry();
        }
        

        
    }
}