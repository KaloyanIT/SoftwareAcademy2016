using System;

class PrintADeck
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string[] cards = new[]
        {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"
        };

        string[] paints = new[] {"of spades", "of clubs", "of hearts", "of diamonds"};
        int i = 0;
        while (a != cards[i])
        {
            for (int j = 0; j < paints.Length; j++)
            {
                if (j == paints.Length - 1)
                {
                    Console.Write("{0} {1}", cards[i], paints[j]);
                    //Console.WriteLine();
                    continue;                   
                }
                Console.Write("{0} {1}, ", cards[i], paints[j]);
            }
            Console.WriteLine();
            i++;
        }
        if (a.ToString() == cards[i])
        {
            for (int j = 0; j < paints.Length; j++)
            {                
                if (j == paints.Length - 1)
                {
                    Console.Write("{0} {1}", cards[i], paints[j]);
                    Console.WriteLine();
                    continue;
                }
                Console.Write("{0} {1}, ", cards[i], paints[j]);
            }
        }
    }
}

