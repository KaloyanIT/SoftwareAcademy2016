using System;
using System.Linq;

class AddingPolynomials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string firstPoly = Console.ReadLine(); //first polynomials as string
        string secondPoly = Console.ReadLine(); //second polynomials as string
        int[] first = new int[n];
        var numbers = firstPoly.Split(' ').ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            first[i] = int.Parse(numbers[i]);
        }
        int[] second = new int[n];
        var secondNumbers = secondPoly.Split(' ').ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            second[i] = int.Parse(secondNumbers[i]);
        }
        AddPolynomials(first, second);
    }

    static void AddPolynomials(int[] first, int[] second)
    {
        int sum = 0;
        for (int i = 0; i < first.Length; i++)
        {
            sum = first[i] + second[i];
            Console.Write(sum + " ");
        }
    }

}

