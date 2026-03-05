using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello Learning05 World!");

        Console.Clear();

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Navy Blue", 2);
        shapes.Add(s1);

        Rectagle s2 = new Rectagle("Gray", 3, 6);
        shapes.Add(s2);

        Circle s3 = new Circle("White", 2);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"\nThe {color} shape has an area of {Math.Round(area,3)}.");
        }
        Console.WriteLine();
    }
}