using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello Foundation3 World!\n");
        Console.Clear();

        List<Event> events = new List<Event>();

        Address lectureAddress = new Address("123 Main st", "Rexburg", "ID", "USA");
        Address receptionAddress = new Address("456 Second Main st", "Provo", "UT", "USA");
        Address outdoorAddress = new Address("789 Third Main Ave", "Kaysville", "UT", "USA");

        Lecture lecture = new Lecture("Intro to D&D", "Learn the basics of D&D and character creation", "April 5, 2026", "12:00 PM", lectureAddress, "Jacob Derington", 50);
        Reception reception = new Reception("D&D Game Night", "A place where you can play D&D with others", "Thursdays", "6:00 PM", receptionAddress, "rsvp@dndclub.com");
        Outdoor outdoor = new Outdoor("D&D Live Role Play Campain", "Dress up and roleplay your campaign", "May 23, 2026", "1:00 PM", outdoorAddress, "Cloudy");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);

        foreach (Event a in events)
        {
            Console.WriteLine("\nSTANDARD DETAILS:");
            Console.WriteLine(a.GetStandard());

            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(a.GetFull());

            Console.WriteLine("\nSHORT DESCRIPTION:");
            Console.WriteLine(a.GetShortDescription());
        }

        // Console.WriteLine("\nSTANDARD DETAILS:");
        // Console.WriteLine(lecture.GetStandard());
        // Console.WriteLine("\nSTANDARD DETAILS:");
        // Console.WriteLine(reception.GetStandard());
        // Console.WriteLine("\nSTANDARD DETAILS:");
        // Console.WriteLine(outdoor.GetStandard());
        // Console.WriteLine();

        // Console.WriteLine("\nFULL DETAILS:");
        // Console.WriteLine(lecture.GetFull());
        // Console.WriteLine("\nFULL DETAILS:");
        // Console.WriteLine(reception.GetFull());
        // Console.WriteLine("\nFULL DETAILS:");
        // Console.WriteLine(outdoor.GetFull());
        // Console.WriteLine();

        // Console.WriteLine("\nSHORT DESCRIPTION:");
        // Console.WriteLine(lecture.GetShortDescription());
        // Console.WriteLine("\nSHORT DESCRIPTION:");
        // Console.WriteLine(reception.GetShortDescription());
        // Console.WriteLine("\nSHORT DESCRIPTION:");
        // Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine();
    }
}