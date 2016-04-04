using System;

//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class AgeAfter10Years
{
    public static int yearsNow;
    static void Main(string[] args)
    {
        
        string[] input = Console.ReadLine().Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
        int month = int.Parse(input[0]);
        int day = int.Parse(input[1]);
        int birthdayYear = int.Parse(input[2]);                
        if (birthdayYear >= 2016)
        {
            Console.WriteLine(0);
            Console.WriteLine(10);
        }
        else
        {
            DateTime birthday = new DateTime(birthdayYear, month, day);
            DateTime now = DateTime.Now;
            Console.WriteLine(CalculateAge(birthday, now));
            Console.WriteLine(Add10Years(yearsNow));
        }

    }

    static int CalculateAge(DateTime birthday, DateTime now)
    {
        yearsNow = now.Year - birthday.Year;
        if (birthday.Month > now.Month)
        {
            yearsNow--;
        }
        if (birthday.Month == now.Month && birthday.Day > now.Day)
        {
            yearsNow--;
        }
        return yearsNow;
    }

    static int Add10Years(int yearsNow)
    {
        int yearsAfter10 = yearsNow + 10;
        return yearsAfter10;
    }
}

