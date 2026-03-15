public class Record
{
    public void CreateTxt(List<Goals> goals)
    {
        Console.Write("\nWhat is the file name (put '.txt' at the end)? ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goals goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.PointValue}|{goal.Description}");
            }
        }

        Console.WriteLine($"Goals successfully added to {fileName}.\n");
    }
}