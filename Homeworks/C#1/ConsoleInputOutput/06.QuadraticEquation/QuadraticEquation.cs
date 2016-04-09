using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double disrminant = (b * b) - (4 * (a * c));
        double root1 = (-b - Math.Sqrt(disrminant)) / (2 * a);
        double root2 = (-b + Math.Sqrt(disrminant)) / (2 * a);
        if (disrminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            if (root1 == root2)
            {
                Console.WriteLine("{0:0.00}", root1);
            }
            else
            {
                Console.WriteLine("{0:0.00}", root1);
                Console.WriteLine("{0:0.00}", root2);
            }
            
            
        }
    }
}

