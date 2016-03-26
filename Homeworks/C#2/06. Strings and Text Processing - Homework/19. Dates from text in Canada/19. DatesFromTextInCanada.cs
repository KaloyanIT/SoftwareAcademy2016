namespace DatesFromTextInCanada
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;

    /*•	Write a program that extracts from a given text all dates that match the 
                * format DD.MM.YYYY.
                 •	Display them in the standard date format for Canada.*/

    class DatesFromTextInCanada
    {
        static void Main()
        {
            string text = "23.05.2015 is the day of the win of 18.12.2015";
            string pattern = @"(?<days>[0-9]{2})\.(?<months>[0-9]{2})\.(?<days>[0-9]{4})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            
            for (int i = 0; i < dates.Length; i++)
            {
                //dates[i] = matches[i];
            }
        }
    }
}
