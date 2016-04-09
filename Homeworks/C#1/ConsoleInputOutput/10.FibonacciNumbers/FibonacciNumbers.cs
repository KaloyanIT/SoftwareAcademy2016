using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int arrayLength = n;
        if (n < 1)
        {
            Console.WriteLine("n must be greater");
        }
        if (n <= 2)
        {
            arrayLength = 2;
        }
        int[] fibonacci = new int[arrayLength];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        if (n == 1)
        {
            Console.WriteLine(fibonacci[0]);
        }
        if (n == 2)
        {
            Console.WriteLine(fibonacci[0] + ", " + fibonacci[1]);
        }
        if (n > 2)
        {
            Console.Write(fibonacci[0] + ", " + fibonacci[1]);
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                Console.Write(", " + fibonacci[i]);
            }
        }
    }
}

