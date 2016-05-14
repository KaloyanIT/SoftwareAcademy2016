using System;

//•	Write a program to convert from any numeral system of given base s to any other 
//  numeral system of base d (2 ≤s, d ≤ 16).

class OneSystemToAnyOther
{
    static void Main()
    {
        
        //Console.Write("Write numeral system form 2, 8, 10, 16: ");
        int numberBase = int.Parse(Console.ReadLine());
        //Console.Write("Write number: ");
        string inputNumber = Console.ReadLine();
        //Console.Write("Write to which num system want to be covnerted 2, 8 , 10, 16: ");
        int toBase = int.Parse(Console.ReadLine());
      
        string converted = Convert.ToString(Convert.ToInt32(inputNumber, numberBase), toBase);
        string another = Convert.ToString(int.Parse(inputNumber), toBase);
        Console.WriteLine(another);
        
    }
}

