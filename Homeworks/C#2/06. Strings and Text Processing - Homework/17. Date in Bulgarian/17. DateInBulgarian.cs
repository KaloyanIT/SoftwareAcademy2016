namespace DateInBulgaria
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    /*•	Write a program that reads a date and time given in the format:
             * day.month.year hour:minute:second and prints the date and time 
             * after 6 hours and 30 minutes (in the same format) along with the 
             * day of week in Bulgarian.*/

    class DateInBulgarian
    {
        static void Main()
        {
            string textDate = Console.ReadLine();
            string[] spaceSplit = textDate.Split(' ').ToArray();
            string[] dateSplit = spaceSplit[0].Split('.').ToArray();
            string[] timeSplit = spaceSplit[1].Split(':').ToArray();
            var dateParse = new List<int>();
            var timeParse = new List<int>();
            for (int i = dateSplit.Length - 1; i >= 0; i--)
            {
                dateParse.Add(int.Parse(dateSplit[i]));
            }
            for (int i = 0; i < timeSplit.Length; i++)
            {
                timeParse.Add(int.Parse(timeSplit[i]));
            }
            var date = new DateTime(dateParse[0], dateParse[1], dateParse[2], timeParse[0], timeParse[1], timeParse[2]);
            var dateAfter6Hours = date.AddHours((double)6).AddMinutes((double)30);
            Console.WriteLine("{0:dd.MM.yyyy H:mm:ss}", dateAfter6Hours);
            string day = (dateAfter6Hours.DayOfWeek).ToString();
            Console.OutputEncoding = Encoding.UTF8;
            DaysOfWeek(day);
        }

        static void DaysOfWeek(string day)
        {
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Понеделник");
                    break;
                case "Tuesday":
                    Console.WriteLine("Вторник");
                    break;
                case "Wednesday":
                    Console.WriteLine("Сряда");
                    break;
                case "Thursday":
                    Console.WriteLine("Четвъртък");
                    break;
                case "Friday":
                    Console.WriteLine("Петък");
                    break;
                case "Saturday":
                    Console.WriteLine("Събота");
                    break;
                case "Sunday":
                    Console.WriteLine("Неделя");
                    break;
                default:
                    Console.WriteLine("Wrong");
                    break;
            }
        }
    }
}