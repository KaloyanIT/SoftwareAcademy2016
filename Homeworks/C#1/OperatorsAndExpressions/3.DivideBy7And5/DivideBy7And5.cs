using System;

//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided(without remainder) by 7 and 5 at the same time.

class DivideBy7And5
{
    static void Main(string[] args)
    {        
        int checkNum = int.Parse(Console.ReadLine());
        if (checkNum % 35 == 0)
        {
            Console.WriteLine("true {0}", checkNum);
        }
        else
        {
            Console.WriteLine("false {0}", checkNum);
        }
    }
}

