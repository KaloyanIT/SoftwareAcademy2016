namespace CalculationProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class CalculationProblem
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            var letterArray = input.Split(' ').ToList();
            int inputWordLength = word.Length - 1;
            int[] positions = new int[inputWordLength];
            for (int i = 0; i < word.Length; i++)
            {
                positions[i] = letterArray.IndexOf(word[i].ToString());
            }
            var sum = 0;
            for (int a = 0; a < positions.Length; a++)
            {
                sum += positions[a] * (ToPower23(positions.Length - 1));
            }
            Console.WriteLine(sum);
        }

        static int ToPower23(int power)
        {
            int sum = 1;
            for (int i = 1; i <= power; i++)
            {
                sum *= 23;
            }
            return sum;
        }
    }
}
