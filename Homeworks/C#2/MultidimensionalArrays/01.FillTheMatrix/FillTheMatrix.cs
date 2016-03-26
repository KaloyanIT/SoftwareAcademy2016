using System;

//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

class FillTheMatrix
{
    static void Main(string[] args)
    {
        int[,] matrixA = new int[4, 4];
        int cols = matrixA.GetLength(1);
        int rows = matrixA.GetLength(0);
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                matrixA[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Console.Clear();
        PrintMatrix(matrixA, rows, cols);
    }

    static void PrintMatrix(int[,] matrixA, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0,3}", matrixA[row, col]);
            }
            Console.WriteLine();
        }
    }
}

