using System;
using System.Linq;

//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main(string[] args)
    {
        char[] array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string word = "ragnar"; //Console.ReadLine();
        var wordToCharArray = word.ToCharArray();
        Console.Write("Position in alphabet: ");
        for (int i = 0; i < wordToCharArray.Length; i++)
        {
            for (int a = 0; a < array.Length - 1; a++)
            {
                if (wordToCharArray[i] == array[a])
                {
                    Console.Write(++a  + ", ");
                    break;
                }
            }
        }
    }
}

