using System;

//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n(n ≤ 100) is prime(i.e.it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

class CheckNumber
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        //if (inputNum < 0)
        //{
        //    Console.WriteLine("false");
        //}
        //if (inputNum == 0 || inputNum == 1)
        //{
        //    Console.WriteLine("false");
        //    Console.ReadLine();
        //}
        //else
        //{
        //    for (int a = 2; a <= inputNum / 2; a++)
        //    {
        //        if (inputNum % a == 0)
        //        {
        //            Console.WriteLine("false");
        //            return;
        //        }
        //    }
        //    Console.WriteLine("true");
        //    Console.ReadLine();


        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(input); i++)
        {
            if (input%i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (input == 1)
        {
            isPrime = false;
        }
        if (input == 2)
        {
            isPrime = true;
        }
        if (input < 0 )
        {
            isPrime = false;
        }
        if (isPrime == true)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }


    }
}