public class Record
{
    public void SaveGoals(List<Goals> goals)
    {
        Console.Write("\nWhat is the file name (put '.txt' at the end)? ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goals goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine($"\nGoals successfully saved to {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError saving file: {ex.Message}\n");
        }
    }
}