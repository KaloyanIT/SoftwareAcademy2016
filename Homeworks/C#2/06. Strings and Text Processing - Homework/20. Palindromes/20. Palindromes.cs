namespace Palindromes
{
    using System;

    //•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

    class Palindromes
    {
        static void Main()
        {
            string text = "ABBA civic";
            string[] wordsArray = text.Split(' ');
            foreach (var word in wordsArray)
            {
                if (IsPalindrome(word))
                {
                    Console.WriteLine(word);
                }
            }
        }

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}