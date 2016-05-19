using System;

class CofeeMachine
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine()); //0.05
        int n2 = int.Parse(Console.ReadLine()); //0.10
        int n3 = int.Parse(Console.ReadLine()); //0.20
        int n4 = int.Parse(Console.ReadLine()); //0.50
        int n5 = int.Parse(Console.ReadLine()); //1
        double amountOfMoney = (n1*0.05) + (n2*0.10) + (n3*0.20) + (n4 * 0.50) + (n5*1);
        double a = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        //Console.WriteLine(amountOfMoney);
        if (a < p)
        {
            Console.WriteLine("More {0:F2}", p - a);
        }
        if (a >= p )
        {
            double differnce = a - p;
            if (differnce <= amountOfMoney)
            {
                Console.WriteLine("Yes {0:F2}", amountOfMoney - differnce);
            }
            else
            {
                Console.WriteLine("No {0:F2}", differnce - amountOfMoney);
            }          
        }
       

    }
}

