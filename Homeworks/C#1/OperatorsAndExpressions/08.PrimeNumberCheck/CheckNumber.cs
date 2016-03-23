using System;

//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n(n ≤ 100) is prime(i.e.it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

class CheckNumber
{    
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        if (inputNum < 0)
        {
            Console.WriteLine("Number is < 0");
        }
        if (inputNum == 0 || inputNum == 1)
        {
            Console.WriteLine(inputNum + "is not prime");
            Console.ReadLine();
        }
        else
        {
            for (int a = 2; a <= inputNum / 2; a++)
            {
                if (inputNum % a == 0)
                {
                    Console.WriteLine(inputNum + "is not a prime number");
                    return;
                }
            }
            Console.WriteLine(inputNum + "is a prime number");
            Console.ReadLine();
        }
    }
}