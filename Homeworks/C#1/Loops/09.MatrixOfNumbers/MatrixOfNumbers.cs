using System;
using System.Data;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        int row = 1;
        int col = 0;
        int number = 1;
        while (true)
        {
            col++;
            if (col <= n)
            {
               Console.Write(number + " ");            
               number++;
            }
            else
            {
                number = row + 1;
                row++;
                col = 0;
                Console.WriteLine();
            }
            if (row > n)
            {
                break;
            }
            i++;
        }
    }
}

