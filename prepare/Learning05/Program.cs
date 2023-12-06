using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rec1 = new Rectangle("Green", 3, 4);
        Circle cir1 = new Circle("Red", 7);
        Circle cir2 = new Circle("Yellow", 4);
        Rectangle rec2 = new Rectangle("Black", 2, 6);
        Circle cir3 = new Circle("Blue", 4);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(rec1);
        shapes.Add(rec2);
        shapes.Add(cir1);
        shapes.Add(cir2);
        shapes.Add(cir3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetString();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color} -- Area: {area}");

        }
        

        


    }
}