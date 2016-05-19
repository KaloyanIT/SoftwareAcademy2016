using System;

class Circle
{
    static void Main(string[] args)
    {
        string inputRadius = Console.ReadLine();
        double radius = double.Parse(inputRadius);
        double pi = Math.PI;
        double perimeter = (2 * radius) * pi;       
        double area = pi * (radius * radius);
        Console.WriteLine("{0:0.00} {1:0.00}",perimeter, area);
    }
}

