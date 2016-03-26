namespace DateDifference
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    //•	Write a program that reads two dates in the format:
    //  day.month.year and calculates the number of days between them.

    class DateDifference
    {
        static void Main()
        {
            string textStartDate = Console.ReadLine();
            string textEndDate = Console.ReadLine();
            string[] startDateArray = textStartDate.Split('.').ToArray();
            string[] endDateArray = textEndDate.Split('.').ToArray();
            var startDate = new List<int>();
            var endDate = new List<int>();
            for (int i = 2; i >= 0; i--)
            {
                startDate.Add(int.Parse(startDateArray[i]));
                endDate.Add(int.Parse(endDateArray[i]));
            }

            //foreach (var item in startDate)
            //{
            //     Console.WriteLine(item);
            //}
            var date1 = new DateTime(startDate[0], startDate[1], startDate[2]);
            var date2 = new DateTime(endDate[0], endDate[1], endDate[2]);
            //Console.WriteLine("{0:dd.MM.yyyy}", date1);
            //Console.WriteLine("{0:dd.MM.yyyy}", date2);
            var a = (date2 - date1).TotalDays;
            Console.WriteLine("Days between dates: " + a);
            
            

            
        }
    }
}
