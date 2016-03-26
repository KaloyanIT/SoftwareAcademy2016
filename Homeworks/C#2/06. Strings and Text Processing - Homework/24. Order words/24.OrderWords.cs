namespace OrderWords
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    //•	Write a program that reads a list of words, separated by spaces 
    //  and prints the list in an alphabetical order.

    class OrderWords
    {
        static void Main()
        {
            string text = "koko hoko boko boko soko coko moko foko maika ti";
            string[] words = text.Split(' ').ToArray();
            var order = new List<string>();
            Array.Sort(words);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }

       
    }
}