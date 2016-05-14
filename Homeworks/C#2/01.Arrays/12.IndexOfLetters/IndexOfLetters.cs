using System;
using System.Runtime.InteropServices;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char currentChar = 'a';
        for (int i = 0; i < input.Length; i++)
        {
            currentChar = input[i];
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (currentChar == alphabet[j])
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}

