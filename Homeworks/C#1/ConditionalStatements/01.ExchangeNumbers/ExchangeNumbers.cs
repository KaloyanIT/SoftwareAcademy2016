using System;

class ExchangeNumbers
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            double c = a;
            a = (a + b) - c;
            b = c;
        }       
        Console.WriteLine("{0} {1}", a, b);
    }
}

