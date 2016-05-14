using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        string firstChars = Console.ReadLine();
        string secondChars = Console.ReadLine();

        if (String.Compare(firstChars, secondChars) < 0)
        {
            Console.WriteLine("<");
        }
        if (String.Compare(firstChars, secondChars) == 0)
        {
            Console.WriteLine("=");
        }
        if (String.Compare(firstChars, secondChars) > 0)
        {
            Console.WriteLine(">");
        }


    }
}

