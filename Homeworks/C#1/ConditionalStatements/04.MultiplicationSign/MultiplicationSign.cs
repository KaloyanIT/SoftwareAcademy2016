using System;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        if (a * b * c < 0)
        {
            Console.WriteLine("-");
        }
        if (a * b * c > 0)
        {
            Console.WriteLine("+");
        }
    }
}

