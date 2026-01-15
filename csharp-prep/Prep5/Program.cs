using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name;
        name = PromptUserName();

        int num;
        num = PromptUserNumber();

        int birth;
        birth = PromtUserBirthYear();

        float sr;
        sr = SquareNumber(num);

        DisplayResult(name, sr, birth);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("\nWelcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        string userNum = Console.ReadLine();
        int num = int.Parse(userNum);
        return num;
    }
    static int PromtUserBirthYear ()
    {
        Console.Write("Please enter the year you were born: ");
        string birth = Console.ReadLine();
        int b = int.Parse(birth);
        return b;
    }
    static float SquareNumber (int number)
    {
        float sr = number * number;
        return sr;
    }
    static void DisplayResult (string name, float square, int birth)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {2025 - birth} this year.\n");
    }
}