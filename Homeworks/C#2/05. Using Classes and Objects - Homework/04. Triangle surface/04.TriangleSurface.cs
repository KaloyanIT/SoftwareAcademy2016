using System;


/*•	Write methods that calculate the surface of a triangle by given:
           o	Side and an altitude to it;
           o	Three sides;
           o	Two sides and an angle between them;
         •	Use System.Math.*/

class TriangleSurface
{
    static void Main()
    {
        //CalculateSurfaceBySide();
        //CalculateSurfaceByThreeSides();
        CalculateSurfaceByAngelAndTwoSides();
    }

    static void CalculateSurfaceBySide()
    {
        Console.Write("Enter one side: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter altidute to it: ");
        double altidute = double.Parse(Console.ReadLine());
        double surface = (side * altidute) / 2;
        Console.WriteLine("Surface is: {0}", surface);
    }

    static void CalculateSurfaceByThreeSides()
    {
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter side c: ");
        double c = double.Parse(Console.ReadLine());
        double halfPerimeter = (a + b + c) / 2;
        double formula = halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c);
        double surface = Math.Sqrt(formula);
        Console.WriteLine("Surface is: {0}", surface);
    }

    static void CalculateSurfaceByAngelAndTwoSides()
    {
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter angle c: ");
        double c = double.Parse(Console.ReadLine());
        double cosAngle = Math.Sin(c);
        double surface = (a * b * cosAngle) / 2;
        Console.WriteLine("Surface is: {0}", surface);
    }
}

