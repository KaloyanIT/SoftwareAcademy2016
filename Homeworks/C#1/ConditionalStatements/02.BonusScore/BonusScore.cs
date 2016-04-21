using System;
using System.Runtime.InteropServices;

class BonusScore
{
    static void Main(string[] args)
    {
        int score = int.Parse(Console.ReadLine());        
        if (score > 9 || score <= 0)
        {
            Console.WriteLine("invalid score");
        }
        if (score >= 1 && score <= 3)
        {
            score *= 10;
            Console.WriteLine(score);
        }
        if (score >= 4 && score <= 6)
        {
            score *= 100;
            Console.WriteLine(score);
        }
        if (score >= 7 && score <= 9)
        {
            score *= 1000;
            Console.WriteLine(score);
        }
        
    }
}

