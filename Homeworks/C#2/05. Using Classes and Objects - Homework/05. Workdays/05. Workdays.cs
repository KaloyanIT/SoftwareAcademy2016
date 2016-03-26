using System;

/*•	Write a method that calculates the number of workdays between today and given date, 
         * passed as parameter.
          •	Consider that workdays are all days from Monday to Friday except a fixed list of public 
         * holidays specified preliminary as array.*/

class Workdays
{
    static void Main()
    {
        var today = DateTime.Today;
        Console.Write("Day: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Mounth: ");
        int mounth = int.Parse(Console.ReadLine());
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        var givenDate = new DateTime(year, mounth, day);
        

    }
}

