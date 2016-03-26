namespace ReadFileContents
{
    using System;
    using System.IO;

    /*•	Write a program that enters file name along with its full file path 
             * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
              •	Find in MSDN how to use System.IO.File.ReadAllText(…).
              •	Be sure to catch all possible exceptions and print user-friendly error messages.*/


    class ReadFileContents
    {
        static void Main()
        {
            try
            {
                string path = @"C:\WINDOWS\win.ini";
                //string path = Console.ReadLine();
                var a = File.ReadAllText(path);
                Console.WriteLine(a);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Invalid path!");
            }
            

        }
    }
}