namespace ReverseSentence
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    //•	Write a program that reverses the words in given sentence.

    class ReverseSentence
    {
        static void Main()
        {
            ////string text = "C# is not C++, not PHP and not Delphi!";
            ////char[] splitters = { ' ', ',', '!' };
            ////string[] splitted = text.Split(splitters).ToArray();
            ////vzemam ot char array-a znacite i posle obrushtam masiva i gi slagam na String.Empty mestata
            ////string reversed = String.Empty;
            ////for (int i = 0; i < splitted.Length - 1; i++)
            ////{
                
            ////}
            //string text = "C# is not C++, not PHP and not Delphi!";
            ////string edited = String.Empty;
            //var edited = new List<string>();
            //for (int i = text.Length - 2; i >= 0; i--)
            //{
            //    edited.Add(text[i].ToString());
            //}
            //foreach (var item in edited)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] words = edited.ToArray();
            //foreach (var kk in words)
            //{
            //    Console.WriteLine(kk);
            //}
            string text = "C# is not C++, not PHP and not Delphi!";
            string oop = string.Join(" ", text.Split(' ').Reverse());
            Console.WriteLine(oop);
        }
    }

}
