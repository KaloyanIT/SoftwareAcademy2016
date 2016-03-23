using System;

//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point(x, y) if it is within the circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2).

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the x coordinate:");
        string strX = Console.ReadLine();
        Console.Write("Enter y coordinate:");
        string strY = Console.ReadLine();
        double pointX = double.Parse(strX);
        double pointY = double.Parse(strY);
        double radius = 1.5;
        double centerX = 1;
        double centerY = 1;

        if ((((pointX - centerX) * (pointX - centerX)) + ((pointY - centerY) * (pointY - centerY)) <= (radius * radius)) &&
            ((pointX >= -1 && pointX <= 5) && (pointY <= 1 && pointX >= -1)))
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K((1,1),3) and in rectangle", pointX, pointY);
        }
        else
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is out of the circle K((1,1),3) or out of rectangle", pointX, pointY);
        }
    }
}

