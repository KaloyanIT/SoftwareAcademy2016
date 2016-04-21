using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int i = input.Length - 1;
        int position = 0;
        long result = 0;
        long currentNum = 0;
        while (i >= 0)
        {
            currentNum = long.Parse(input[i].ToString());
            result += (currentNum * (long)Math.Pow((double)2, (double)position));
            position++;
            i--;
        }
        Console.WriteLine(result);
    }
}

