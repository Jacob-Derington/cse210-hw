using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        
        Console.Write("Enter number: ");
        string num = Console.ReadLine();
        int n = int.Parse(num);

        while (n != 0)
        {
            numbers.Add(n);

            Console.Write("Enter number: ");
            num = Console.ReadLine();
            n = int.Parse(num);
        }
        
        float sum = 0;
        float ave = 0;
        float big = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            ave += 1;
            if (numbers[i] > big)
            {
                big = numbers[i];
            }
        }
        

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/ave}");
        Console.WriteLine($"The largest number is: {big}\n");
    }
}