using System;

//•	Write a program that reads a year from the console and checks whether it is a leap one.
//•	Use System.DateTime.

class LeapYear
{
    static void Main()
    {
        Console.Write("Write year to chek is it leap: ");
        int year = int.Parse(Console.ReadLine());
        var isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine(isLeap);
    }
}

