namespace SquareRoot
{
    using System;
    using System.Numerics;
    /*•	Write a program that reads an integer number and calculates and prints its square root.
                o	If the number is invalid or negative, print Invalid number.
                o	In all cases finally print Good bye.
              •	Use try-catch-finally block.*/


    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(number));
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}

