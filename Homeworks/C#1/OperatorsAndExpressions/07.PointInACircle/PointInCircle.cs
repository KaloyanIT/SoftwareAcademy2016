using System;

//Problem 7. Point in a Circle

//Write an expression that checks if given point(x, y) is inside a circle K({ 0, 0}, 2).

class PointInCircle
{
    //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
    static void Main(string[] args)
    {
        Console.Write("Enter valuie for x;");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter value for y:");
        double y = double.Parse(Console.ReadLine());
        double doubleX = x * x;
        double doubleY = y * y;
        double radius = 2 * 2;
        if ((doubleY + doubleX) < radius)
        {
            Console.WriteLine("In Circle");
        }
        else
        {
            Console.WriteLine("Out of circle");
        }

    }
}

