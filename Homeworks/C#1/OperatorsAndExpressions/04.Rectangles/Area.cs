using System;

//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Area
{
    static void Main(string[] args)
    {
        Console.Write("Width:");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height:");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = 2*(width + height);
        Console.WriteLine("Perimeter is: {0}", perimeter);
        Console.WriteLine("The rectangle’s area is: {0}", area);
    }
}