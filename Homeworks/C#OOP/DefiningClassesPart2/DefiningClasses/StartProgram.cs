namespace DefiningClasses
{
    using System;

    //public [Version]
    public class StartProgram
    {
        private static void Main()
        {
            ////var a = new Point3D(2, 2, 2);
            ////System.Console.WriteLine(a);
            ////var b = new GenericList<int>(5);
            ////b.Add(10);
            ////b.Add(100);
            ////b.Add(1000);
            ////b.Add(10000);
            ////b.Add(90);

            ////System.Console.WriteLine(b.Min());
            ////System.Console.WriteLine(b.Max());
            ////var a = 5.CompareTo(10);
            ////System.Console.WriteLine(a);
            Random generator = new Random();
            var firstMatrix = new Matrix<int>(10, 10);
            var secondMatrix = new Matrix<int>(10, 10);
            int i = 1;
            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    firstMatrix[row, col] = i++;
                    secondMatrix[row, col] = i;
                }
            }             
            firstMatrix.PrintMatrix();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine();
            secondMatrix.PrintMatrix();
            var newMatrix = firstMatrix + secondMatrix;
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            newMatrix.PrintMatrix();
            
        }
    }
}
