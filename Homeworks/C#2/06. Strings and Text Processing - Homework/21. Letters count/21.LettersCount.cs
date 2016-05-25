namespace LetterCount
{

    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    //•	Write a program that reads a string from the console and prints all different letters in the 
    //  string along with information how many times each letter is found.

    class LettersCount
    {
        static void Main()
        {
            string text = "aaaaaabbbbbbxxxssdsss";
            int[] unicode = new int[65536];
            
            foreach (var c in text)
            {
                unicode[c]++;
            }
            for (int i = 0; i < unicode.Length; i++)
            {
                if (i == 32)
                {
                    continue;
                }
                if (unicode[i] == 0)
                {
                    continue;
                }
                else
                {
                    
                    Console.Write(Convert.ToChar(i));
                }
            }
            Console.WriteLine();
        }
    }
}