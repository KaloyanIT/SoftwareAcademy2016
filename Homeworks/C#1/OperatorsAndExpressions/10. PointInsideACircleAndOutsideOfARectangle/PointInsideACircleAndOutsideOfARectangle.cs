using System;

//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point(x, y) if it is within the circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2).

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main(string[] args)
    {
        string strX = Console.ReadLine();       
        string strY = Console.ReadLine();
        double pointX = double.Parse(strX);
        double pointY = double.Parse(strY);
        double radius = 1.5;
        double centerX = 1;
        double centerY = 1;
        bool isInCircle = ((pointX - centerX)*(pointX - centerX)) + ((pointY - centerY)*(pointY - centerY)) <=
                          (radius*radius);
        bool isInRectangle = ((pointX >= -1 && pointX <= 5) && (pointY <= 1 && pointX >= -1));

        if (isInCircle)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }
        if (isInRectangle)
        {
            Console.Write("inside rectangle");
        }
        else
        {
            Console.Write("outside rectangle");
        }
    }
}

