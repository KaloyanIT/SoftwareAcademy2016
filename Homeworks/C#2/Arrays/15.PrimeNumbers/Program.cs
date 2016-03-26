using System;
using System.Collections.Generic;
using System.Linq;

//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        //List<int> numbers = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        List<int> primeNumbers = new List<int>();
        for (int i = 2; i < 1000; i++)
        {
            numbers.Add(i);
        }
        int index = 0;
        int primeChecker = numbers[index];
        var item = 0;
        do
        {
            for (int a = 0; a < numbers.Count - 1; a++)
            {
                if (numbers[a] % primeChecker == 0)
                {
                    if (numbers[a] == primeChecker)
                    {
                        continue;
                    }
                    numbers.Remove(numbers[a]);
                }                
            }
            primeNumbers.Add(primeChecker);
            primeChecker = numbers[index++];
            item = numbers[numbers.Count - 1];
        } while (item > primeChecker);
        //foreach (var items in numbers)
        //{
        //    Console.WriteLine(items + ", ");
        //}
        Console.WriteLine();
        foreach (var number in primeNumbers)
        {
            Console.WriteLine(number);
        }

        
    }
}

