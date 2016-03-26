using System;
using System.Linq;
class SubstractingPolynomials
{

    static int degree = 5;
    static int[] sumResult = new int[degree + 1];
    static void Main()
    {
        Console.Write("Enter you polynomial degree: ");
        //int degree = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] polyDegrees = new int[degree + 1];
        for (int i = polyDegrees.Length - 1; i >= 0; i--)
        {
            Console.Write("x^" + i + " = ");
            polyDegrees[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Second polynomial");
        int[] secondPolyDegrees = new int[degree + 1];
        for (int i = secondPolyDegrees.Length - 1; i >= 0; i--)
        {
            Console.Write("x^" + i + " = ");
            secondPolyDegrees[i] = int.Parse(Console.ReadLine());
        }
        PrintArray(polyDegrees);
        Console.WriteLine();
        Console.WriteLine("+");
        PrintArray(secondPolyDegrees);
        SumPolynomials(polyDegrees, secondPolyDegrees);
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------");
        PrintArray(sumResult);
        Console.WriteLine();
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        PrintArray(polyDegrees);
        Console.WriteLine();
        Console.WriteLine("*");
        PrintArray(secondPolyDegrees);
        MultiplyPolynomials(polyDegrees, secondPolyDegrees);
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------");
        PrintArray(sumResult);
        Console.WriteLine();
    }

    static void PrintArray(int[] array)
    {
        //Console.Write("{ ");
        array.Reverse();
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(" " + array[i] + "x^" + i);
            if (i == 0)
            {
                Console.Write(" = 0");
            }
            else
            {
                Console.Write(" +");
            }
        }
        //Console.Write("}");
    }

    static void SumPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        firstPolynomial.Reverse();
        secondPolynomial.Reverse();
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            sumResult[i] = firstPolynomial[i] + secondPolynomial[i];
        }
    }

    static void MultiplyPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        firstPolynomial.Reverse();
        secondPolynomial.Reverse();
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            sumResult[i] = firstPolynomial[i] * secondPolynomial[i];
        }
    }
}


