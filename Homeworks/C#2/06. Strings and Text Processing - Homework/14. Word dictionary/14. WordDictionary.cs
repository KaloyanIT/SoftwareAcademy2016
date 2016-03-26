namespace WordDictionary
{
    using System;
    using System.Collections.Generic;


    /*•	A dictionary is stored as a sequence of text lines containing words and 
             * their explanations.
              •	Write a program that enters a word and translates it by using the dictionary.*/


    class WordDictionary
    {
        static void Main()
        {
            var dictonary = new Dictionary<string, string>();
            dictonary.Add(".NET", "platform for applications from Microsoft");
            dictonary.Add("CLR", "managed execution environment for .NET");
            dictonary.Add("namespace", "hierarchical organization of classes");
            string word = Console.ReadLine();
            Console.WriteLine(dictonary[word]);
        }
    }
}
