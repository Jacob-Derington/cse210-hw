using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello Foundation1 World!");
        Console.Clear();

        Video video1 = new Video("D&D Crashouts", "Jacob", 300);
        Comment c1 = new Comment("user123", "Valid crashout.");
        Comment c2 = new Comment("user789", "That happend to me once.");
        video1.AddComment(c1);
        video1.AddComment(c2);

        Video video2 = new Video("Crying Raccons", "Emosional damage", 700);
        Comment c3 = new Comment("Pain", "So cute and sad");
        Comment c4 = new Comment("RunningMan", "Suffering");
        Comment c5 = new Comment("Flash", "First Comment!");
        video2.AddComment(c3);
        video2.AddComment(c4);
        video2.AddComment(c5);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);

        foreach (Video v in videos)
        {
            Console.WriteLine(v.Display());
        }
    }
}