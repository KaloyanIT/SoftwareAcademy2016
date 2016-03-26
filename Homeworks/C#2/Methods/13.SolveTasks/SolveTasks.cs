using System;
using System.Linq;

//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number 
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("For reverse digits of a number write a");
        Console.WriteLine("For calculates average of a sequence of integer write b");
        Console.WriteLine("For solves a linear equation a*x + b = 0 write c");
        Console.WriteLine();
        char choice = char.Parse(Console.ReadLine());
        if (choice == 'a')
        {
            //decimal number = 2939.21m;
            Console.Write("Enter decimal number to reverse: ");
            decimal number = decimal.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Number must be positive.");
                
            }
            else
            {
                ReverseDigits(number);
            }
            
        }
        if (choice == 'b')
        {
            Console.Write("Enter you sequence length: ");
            int seqLength = int.Parse(Console.ReadLine());
            if (seqLength < 1)
            {
                Console.WriteLine("The sequence mustn't be empty.");
            }
            else
            {
                int[] sequence = new int[seqLength];
                FillArray(sequence, seqLength);
                CalculateAverageSequence(sequence, seqLength);
            }
        }
        if (choice == 'c')
        {
            Console.WriteLine("Solves a equation a*x + b = 0");
            Console.Write("Enter parameter a: ");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A can't be 0.");
            }
            else
            {
                Console.Write("Enter parameter b: ");
                double b = double.Parse(Console.ReadLine());
                SolveEquation(a, b);
            }
        }
        if (choice != 'a' && choice != 'b' && choice != 'c')
        {
            Console.WriteLine("Fatal Error");
        }
        

    }

    static void ReverseDigits(decimal number)
    {
        string numberText = number.ToString();
        Console.Write("Reversed number is: ");
        for (int i = numberText.Length - 1; i >= 0; i--)
        {
            Console.Write(numberText[i]);
        }
        Console.WriteLine();
    }

    static void CalculateAverageSequence(int[] array, int seqLength)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        int averageSum = sum / seqLength;

        Console.WriteLine("Average sum is: {0}", averageSum);
    }

    static void FillArray(int[] array, int seqLength)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter integer for sequence [{0}] : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //int sum = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    sum += array[i];
        //}
        //int averageSum = sum / seqLength;

        //Console.WriteLine("Average sum is: {0}", averageSum);
    }

    static void SolveEquation(double a, double b)
    {
        double x = -b / a;
        Console.WriteLine("X = {0}", x);
    }
}

