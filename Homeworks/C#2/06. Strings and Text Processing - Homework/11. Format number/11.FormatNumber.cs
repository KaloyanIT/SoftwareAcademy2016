namespace FormatNumber
{
    using System;
    using System.Linq;

    /*•	Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
             * percentage and in scientific notation.
              •	Format the output aligned right in 15 symbols.*/


    class FormatNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string decimalNumber = number.ToString("D15");
            string hexadecNumber = number.ToString("X");
            string percentage = number.ToString("P");
            string scientificNotation = number.ToString("E");
            Console.WriteLine("{0, 15}", decimalNumber);
            Console.WriteLine("{0, 15}", hexadecNumber);
            Console.WriteLine("{0, 15}", percentage);
            Console.WriteLine("{0, 15}", scientificNotation);

        }
    }
}
