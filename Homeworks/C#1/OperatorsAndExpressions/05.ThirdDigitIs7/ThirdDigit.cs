using System;

//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int thirdNumber = (number/100) % 10;
        if (thirdNumber == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            
            Console.WriteLine("false {0}", thirdNumber);
        }
    }
}
