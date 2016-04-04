using System;

//Problem 7. Point in a Circle

//Write an expression that checks if given point(x, y) is inside a circle K({ 0, 0}, 2).

class PointInCircle
{    
    static void Main(string[] args)
    {        
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double doubleX = x * x;
        double doubleY = y * y;
        double radius = 2 * 2;
        double difference = Math.Sqrt((x*x) + (y*y));
        if ((doubleY + doubleX) < radius)
        {
            Console.WriteLine("yes {0:F2}", difference);
        }
        else
        {
            Console.WriteLine("no {0:F2}", difference);
        }
        

    }
}

