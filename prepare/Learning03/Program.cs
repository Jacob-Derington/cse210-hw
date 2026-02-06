using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Fraction t1 = new Fraction();
        Console.WriteLine(t1.GetFractionString());
        Console.WriteLine(t1.GetDecimalValue());

        Console.WriteLine();
        Fraction t2 = new Fraction(5);
        Console.WriteLine(t2.GetFractionString());
        Console.WriteLine(t2.GetDecimalValue());

        Console.WriteLine();
        Fraction t3 = new Fraction(3,4);
        Console.WriteLine(t3.GetFractionString());
        Console.WriteLine(t3.GetDecimalValue());

        Console.WriteLine();
        Fraction t4 = new Fraction(1,3);
        Console.WriteLine(t4.GetFractionString());
        Console.WriteLine(t4.GetDecimalValue());

        Console.WriteLine();
        Random random = new Random();
        Fraction t5 = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topV = random.Next(1,11);
            int bottomV = random.Next(1,11);
            t5.SetTop(topV);
            t5.SetBottom(bottomV);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {t5.GetFractionString()} ");
            Console.WriteLine($"Number: {t5.GetDecimalValue()}");
        }

        Console.WriteLine();
    }
}