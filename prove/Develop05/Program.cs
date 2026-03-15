using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello Develop05 World!");
        Console.Clear();

        List<Goals> goals = new List<Goals>();
        int score = 0;
        int level = 0;

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Goal Menu ---");
            Console.WriteLine($"Score: {score} | Level: {level}");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            Console.Clear();

            Record record = new Record();
            Load load = new Load();

            switch (choice)
            {
                case "1": 
                    CreateGoal(goals);
                    break;

                case "2":
                    if (goals.Count == 0)
                    {
                        Console.WriteLine("\nNo goals available.");
                        break;
                    }
                    Console.WriteLine("\nSelect a goal to record:");
                    for (int i = 0; i < goals.Count; i++)
                        Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} ({goals[i].Description})");

                    Console.Write("Enter number: ");
                    int selected = int.Parse(Console.ReadLine()) - 1;

                    if (selected >= 0 && selected < goals.Count)
                    {
                        int earned = goals[selected].RecordEvent();
                        score += earned;

                        int newLevel = score / 100;

                        if (newLevel > level)
                        {
                            level = newLevel;
                            Console.WriteLine($"\n🎉 LEVEL UP! You are now Level {level}! 🎉");
                        }

                        Console.WriteLine($"You earned {earned} points!");
                        Console.WriteLine($"Total Score: {score}");
                        Console.WriteLine($"Current Level: {level}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nGoals List:");
                    for (int i = 0; i < goals.Count; i++)
                        Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} ({goals[i].Description})");
                    break;

                case "4":
                    Console.WriteLine($"Your current score: {score}");
                    Console.WriteLine($"Your current level: {level}");
                    break;

                case "5":
                    record.SaveGoals(goals);
                    break;

                case "6":
                    load.LoadGoals(goals);
                    score = CalculateScore(goals);
                    level = score / 100; 
                    Console.WriteLine($"Goals loaded. Score: {score}, Level: {level}");
                    break;

                case "7":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        Console.WriteLine("\nThanks for makeing new goals!\n");
    }

    static void CreateGoal(List<Goals> goals)
    {
        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string type = Console.ReadLine();
        Console.Clear();

        string goal = type switch
        {
            "1" => "Simple",
            "2" => "Eternal",
            "3" => "Checklist",
            _ => "unknown"
        };

        Console.Write($"\nEnter {goal} goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new Simple(name, description, points));
        }
        else if (type == "2")
        {
            goals.Add(new Eternal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new Checklist(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }

        Console.WriteLine("Goal created successfully!");
        Console.Clear();
    }
    static int CalculateScore(List<Goals> goals)
    {
        int total = 0;
        foreach (var goal in goals)
        {
            if (goal is Simple simple)
            {
                if (simple.IsComplete())
                    total += simple.PointValue;
            }
            else if (goal is Eternal eternal)
            {
                // Eternal goals can be recorded multiple times, but we don’t store count in this version
                // If you track how many times it was recorded, add here
            }
            else if (goal is Checklist checklist)
            {
                total += checklist.PointsEarnedSoFar();
            }
        }
        return total;
    }
}