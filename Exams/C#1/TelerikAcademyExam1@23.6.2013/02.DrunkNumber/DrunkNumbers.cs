using System;
using System.Runtime.InteropServices;

class DrunkNumbers
{    
    static void Main()
    {
        int n = 2;//int.Parse(Console.ReadLine());
        int currrentMitkoBeers = 0;
        int currentVladkoBeers = 0;
        int mitkoBeers = 0;
        int vladkoBeers = 0;
        int rounds = 1;
        int currentLength = 0;        
        string currentNumbers = String.Empty;        
        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber < 0)
            {
                currentNumber *= -1;
            }
            currentNumbers = currentNumber.ToString();
            currentLength = currentNumbers.Length;
            while (rounds <= (currentLength / 2))
            {
                currentVladkoBeers += currentNumber % 10;
                currentNumber /= 10;
                rounds++;
            }
            rounds = 1;
            if (currentLength % 2 != 0)
            {
                currrentMitkoBeers += currentNumber % 10;
                currentVladkoBeers += currentNumber % 10;
                currentNumber /= 10;
            }
            vladkoBeers += currentVladkoBeers;
            currentVladkoBeers = 0;
            while (rounds <= (currentLength / 2))
            {
                currrentMitkoBeers += currentNumber % 10;
                currentNumber /= 10;
                rounds++;
            }
            rounds = 1;
            mitkoBeers += currrentMitkoBeers;
            currrentMitkoBeers = 0;
        }
        if (vladkoBeers > mitkoBeers)
        {
            Console.WriteLine("V {0}", vladkoBeers - mitkoBeers);
        }
        if (mitkoBeers > vladkoBeers)
        {
            Console.WriteLine("M {0}", mitkoBeers - vladkoBeers);
        }
        if (mitkoBeers == vladkoBeers)
        {
            Console.WriteLine("No {0}", mitkoBeers + vladkoBeers);
        }
    }
}

