using System;

//•	Write a program to convert from any numeral system of given base s to any other 
//  numeral system of base d (2 ≤s, d ≤ 16).

class OneSystemToAnyOther
{
    static void Main()
    {
        
        Console.Write("Write numeral system form 2, 8, 10, 16: ");
        int numberBase = int.Parse(Console.ReadLine());
        Console.Write("Write number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.Write("Write to which num system want to be covnerted 2, 8 , 10, 16: ");
        int toBase = int.Parse(Console.ReadLine());
        if (numberBase != 2 && numberBase != 8 && numberBase != 10 && numberBase != 16 && toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
        {
            Console.WriteLine("Can't convert");
        }
        else
        {
            string number = Convert.ToString(inputNumber);
            string converted = Convert.ToString(Convert.ToInt32(number, numberBase), toBase);
            Console.WriteLine(converted);
        }
    }
}

