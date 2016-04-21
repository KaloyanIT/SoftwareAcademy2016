using System;

class OddOrEvenProducts
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 4)
        {
            throw new Exception("error");
        }
        string numbers = Console.ReadLine();
        var a = numbers.Split(' ');        
        long currentNumber = 1;
        long oddProduct = 1;
        long evenProduct = 1;
        for (int i = 1; i <= n; i++)
        {
            currentNumber = long.Parse(a[i - 1]);
            if (i%2 == 0) 
            {
                oddProduct *= currentNumber;
            }
            else
            {
                evenProduct *= currentNumber;
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
        }
    }
}

