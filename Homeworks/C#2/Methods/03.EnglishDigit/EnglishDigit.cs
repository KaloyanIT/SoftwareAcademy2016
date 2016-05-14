using System;

//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

class EnglishDigit
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long lastDegit = number % 10;
        PrintLastDegit(lastDegit);
    }

    static void PrintLastDegit(long lastDegit)
    {
        switch (lastDegit)
        {
            case 0:
                Console.WriteLine("null");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
            default:
                Console.WriteLine("Error");
                break;
            
            
        }
    }
}

