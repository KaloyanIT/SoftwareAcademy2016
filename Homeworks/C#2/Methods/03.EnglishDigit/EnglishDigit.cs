using System;

//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

class EnglishDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int lastDegit = number % 10;
        PrintLastDegit(lastDegit);
    }

    static void PrintLastDegit(int lastDegit)
    {
        switch (lastDegit)
        {
            case 0:
                Console.WriteLine("Last digit is null");
                break;
            case 1:
                Console.WriteLine("Last digit is one");
                break;
            case 2:
                Console.WriteLine("Last digit is two");
                break;
            case 3:
                Console.WriteLine("Last digit is three");
                break;
            case 4:
                Console.WriteLine("Last digit is four");
                break;
            case 5:
                Console.WriteLine("Last digit is five");
                break;
            case 6:
                Console.WriteLine("Last digit is six");
                break;
            case 7:
                Console.WriteLine("Last digit is seven");
                break;
            case 8:
                Console.WriteLine("Last digit is eight");
                break;
            case 9:
                Console.WriteLine("Last digit is nine");
                break;
            default:
                Console.WriteLine("Error");
                break;
            
            
        }
    }
}

