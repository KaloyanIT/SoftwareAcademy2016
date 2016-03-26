namespace DownloadFile
{
    using System;
    using System.Net;


    /*•	Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the 
            * current directory.
             •	Find in Google how to download files in C#.
             •	Be sure to catch all exceptions and to free any used resources in the finally block.*/

    class DownloadFile
    {
        static void Main()
        {
            try
            {
                string url = Console.ReadLine();
                string directory = @"D:\\Downloads";
                WebClient downloader = new WebClient();
                downloader.DownloadFile(url, directory);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
