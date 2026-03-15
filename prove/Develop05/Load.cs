public class Load
{
    public void LoadGoals(List<Goals> goals)
    {
        Console.Write("\nWhat is the filename? ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            Goals goal = null;

            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                goal = new Simple(name, description, points);

                if (complete)
                    goal.RecordEvent();
            }
            else if (type == "EternalGoal")
            {
                goal = new Eternal(name, description, points);
            }
            else if (type == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                goal = new Checklist(name, description, points, target, bonus); 
                
                for (int i = 0; i < completed; i++)
                    goal.RecordEvent();

                goals.Add(goal);
            }

            if (goal != null)
                goals.Add(goal);
        }

        Console.WriteLine($"{fileName} loaded successfully.");
    }

}