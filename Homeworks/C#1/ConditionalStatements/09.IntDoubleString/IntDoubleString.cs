using System;

class IntDoubleString
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if (input == "integer")
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + 1);
        }
        if (input == "real")
        {
            double realNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", realNumber + 1);
        }
        if (input == "text")
        {
            string text = Console.ReadLine();
            Console.WriteLine(text + '*');
        }
    }
}

