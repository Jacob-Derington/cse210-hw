using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        List<Entry> entries = new List<Entry>();
        Console.WriteLine("\nWelcome to the Journal Program!");
        while (running)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("what would you like to do? ");
            string choices = Console.ReadLine();
            int c = int.Parse(choices);

            
            if (c == 1)
            {
                // writes enteryes and saves them for display perpuses
                Console.WriteLine();
                List<string> prompt = new List<string>()
                {
                    "How did I plan my day, and how did it go?",
                    "How was my strugle with homework?",
                    "What did I make today and how did I feel it came out?",
                    "What did I do to get out of my confert zone?",
                    "Did I leave the house? If so what did I do?",
                    "How was D&D this week?",
                    "What do you plan to do this week?"
                };
                Random rand = new Random();
                int questions = rand.Next(prompt.Count);
                string q = prompt[questions];
                Console.WriteLine(q);

                Entry e = new Entry();
                e._date = dateText;
                e._prompt = q;

                Console.Write("> ");
                e._entry = Console.ReadLine();
                entries.Add(e);
                Console.WriteLine();
            }
            else if (c == 2)
            {
                Console.WriteLine();
                foreach (Entry entry in entries)
                {
                    entry.OutputEntry();
                }
            }
            else if (c == 3)
            {
                Console.Write("\nWhat is the filename? ");
                string fileName = Console.ReadLine();

                if (File.Exists(fileName))
                {
                    string[] jounal = File.ReadAllLines(fileName);
                    entries.Clear();

                    foreach (string line in jounal)
                    {
                        string[] parts = line.Split('|');

                        Entry entry = new Entry();
                        entry._date = parts[0];
                        entry._prompt = parts[1];
                        entry._entry = parts[2];

                        entries.Add(entry);
                    }

                    Console.WriteLine($"{fileName} loaded successfully.\n");
                    
                }
                else
                {
                    Console.WriteLine($"File {fileName} not found.\n");
                }
            }
            else if (c == 4)
            {
                Console.Write("\nWhat is the file name(put '.txt' at the end)? ");
                string fileName = Console.ReadLine();

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
                    }
                }
                Console.WriteLine($"Entries successfully added to {fileName}.\n");

            }
            else if (c == 5)
            {
                Console.WriteLine("\nHave a good day.\n");
                running = false;
            }
        }
        
    }
}