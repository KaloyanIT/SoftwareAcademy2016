using System;
using System.Globalization;
using System.Threading;

class Calculate
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;



        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        if (x == 0)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {


            int factorial = 1;
            int i = 1;
            double result = 1;
            double currentX = x;
            while (i <= n)
            {
                factorial *= i;               
                result += factorial/ Math.Pow(x, i);
                i++;
            }

            Console.WriteLine("{0:F5}", result);
        }
    }
}
