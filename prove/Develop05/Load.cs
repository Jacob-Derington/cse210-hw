public class Load
{
    public void GetTxt(List<Goals> goals)
    {
        Console.Write("\nWhat is the filename? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            goals.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                string type = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);
                string description = parts[3];

                Goals goal = null;

                if (type == "SimpleGoal")
                {
                    goal = new Simple(name, description, points);
                }
                else if (type == "EternalGoal")
                {
                    goal = new Eternal(name, description, points);
                }
                else if (type == "ChecklistGoal")
                {
                    // If your checklist goal has additional fields (target, bonus), parse them here
                    goal = new Checklist(name, description, points, 5, 100); 
                    // Replace 5 and 100 with actual saved values if you added them to your file
                }

                if (goal != null)
                    goals.Add(goal);
            }

            Console.WriteLine($"{fileName} loaded successfully.\n");
            
        }
        else
        {
            Console.WriteLine($"File {fileName} not found.\n");
        }
    }

}