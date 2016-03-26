namespace SquareRoot
{
    using System;

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
                uint number = uint.Parse(Console.ReadLine());               
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

