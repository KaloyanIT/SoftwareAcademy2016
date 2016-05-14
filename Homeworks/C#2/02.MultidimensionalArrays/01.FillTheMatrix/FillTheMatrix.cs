using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class FillTheMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //char someChar = char.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        //if (someChar == 'a')
        //{
        //    PrintA(matrix);
        //}
        //if (someChar == 'b')
        //{
        //    PrintB(matrix);
        //}
        //if (someChar == 'c')
        //{
        //    PrintC(matrix);
        //}
        int index = 1;

        //Print every row and every col recursivly till the all matrix is filled with the two methods above FillCol and FillRow

    }

    static void PrintA(int[,] matrix)
    {
        int index = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = index;
                index++;
            }
        }
        PrintMatrix(matrix);
    }

    static void PrintB(int[,] matrix)
    {
        int index = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = index;
                    index++;
                }
            }
            else
            {
                for (int rows = matrix.GetLength(0) - 1; rows >= 0; rows--)
                {
                    matrix[rows, col] = index;
                    index++;
                }
            }
        }
        PrintMatrix(matrix);
    }

    static void PrintC(int[,] matrix)
    {
        int row = matrix.GetLength(0) - 1, col = 0, data = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            do
            {
                data++;
                if (row < 0)
                {
                    row = 0;
                }
                matrix[row, col] = data;
                row++;
                col++;
            } while (row < matrix.GetLength(0));

            row -= col + 1;
            col = 0;
        }

        row = 0;
        col = 1;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            do
            {
                data++;
                matrix[row, col] = data;
                row++;
                col++;
            } while (col < matrix.GetLength(0));

            col -= row - 1;
            row = 0;
        }

        PrintMatrix(matrix);
    }

    static void PrintD()
    {
        
    }

    static void FillRow(int[,] matrix, int row, int col, int index)
    {
        while ()
        {
            
        }
    }

    static void FillCol()
    {
        while (true)
        {
            
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {               
                if (col == matrix.GetLength(1) - 1)
                {
                    Console.Write(matrix[row, col]);
                    continue;
                }
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

