using System;

class AddingPolynomials
{
    static void Main()
    {
        Console.Write("Enter you polynomial degree: ");
        int degree = int.Parse(Console.ReadLine());
        int[] polyDegrees = new int[degree + 1];
        for (int i = polyDegrees.Length - 1; i >= 0; i--)
		{
            Console.Write("x^" + i + " = ");
            polyDegrees[i] = int.Parse(Console.ReadLine());
		}
        PrintArray(polyDegrees);
    }

    static void PrintArray(int[] array)
    {
        Console.Write("{ ");
        foreach (var item in array)
        {

            Console.Write(item + ", ");
        }
        Console.Write("}");
    }
    
}

