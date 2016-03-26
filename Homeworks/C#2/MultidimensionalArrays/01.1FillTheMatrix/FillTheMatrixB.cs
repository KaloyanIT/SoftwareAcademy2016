using System;
class FillTheMatrixB
{
    static void Main()
    {
        int[,] matrixA = new int[4, 4];
        int cols = matrixA.GetLength(1);
        int rows = matrixA.GetLength(0);
        for (int col = 0; col < cols; col++)
        {
            if (col == 0 || col == 2)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrixA[row, col] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    matrixA[row, col] = int.Parse(Console.ReadLine());
                }
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

