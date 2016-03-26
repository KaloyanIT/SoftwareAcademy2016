namespace StringLength
{
    using System;
    using System.Text;

    /*•	Write a program that reads from the console a string of maximum 20 characters. If the 
             * length of the string is less than 20, the rest of the characters should be filled with *.
              •	Print the result string into the console.*/


    class StringLength
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            string stext = Console.ReadLine();
            if (stext.Length > 20)
            {
                Console.WriteLine("String must be smaller than 20 characters.");
            }
            else
            {
                text.Append(stext);
                if (stext.Length < 20)
                {
                    for (int i = stext.Length; i <= 20; i++)
                    {
                        text.Append('*');
                    }
                }
                //text.ToString();
                Console.WriteLine(text.ToString());
            }
        }
    }
}
