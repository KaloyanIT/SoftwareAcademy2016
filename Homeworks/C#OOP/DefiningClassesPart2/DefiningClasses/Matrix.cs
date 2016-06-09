namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class Matrix<T> where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T[,] multiArray;
        private int row;
        private int col;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.multiArray = new T[this.row, this.col];
        }

        public T this[int currentRow, int currentCol]
        {
            get
            {
                if (currentRow > row || currentCol > col)
                {
                    throw new System.StackOverflowException();
                }
                return multiArray[currentRow, currentCol];

            }
            set
            {
                multiArray[currentRow, currentCol] = value;
            }
        }

        public T[,] MultiArray
        {
            get
            {
                return this.multiArray;
            }

            set
            {
                this.multiArray = value;
            }
        }



        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }

            set
            {
                this.col = value;
            }
        }


        ////public void PrintMatrix()
        ////{
        ////    for (int row = 0; row < this.multiArray.GetLength(0); row++)
        ////    {
        ////        for (int col = 0; col < this.multiArray.GetLength(1); col++)
        ////        {
        ////            System.Console.Write(multiArray[row, col] + "| ");
        ////        }
        ////        System.Console.WriteLine();
        ////    }
        ////}

        public void PrintMatrix()
        {
            for (int row = 0; row < multiArray.GetLength(0); row++)
            {
                for (int col = 0; col < multiArray.GetLength(1); col++)
                {
                    Console.Write("{0,6}", multiArray[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (CheckForZeroElements(firstMatrix) || CheckForZeroElements(secondMatrix))
            {
                throw new Exception("There is empty or null values in the matrix");               
            }
            else
            {
                if (firstMatrix.Row != secondMatrix.Row || firstMatrix.Col != secondMatrix.Col)
                {
                    throw new Exception("The matrixs must be with the same size, to be added");
                }
                else
                {
                    Matrix<T> finalMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
                    for (int rows = 0; rows < firstMatrix.Row; rows++)
                    {
                        for (int cols = 0; cols < firstMatrix.Col; cols++)
                        {
                            finalMatrix[rows, cols] = (dynamic)firstMatrix[rows, cols] + secondMatrix[rows, cols];
                        }
                    }
                    return finalMatrix;
                }
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (CheckForZeroElements(firstMatrix) || CheckForZeroElements(secondMatrix))
            {
                throw new Exception("There is empty or null values in the matrix");
            }
            else
            {
                if (firstMatrix.Row != secondMatrix.Row || firstMatrix.Col != secondMatrix.Col)
                {
                    throw new Exception("The matrixs must be with the same size, to be added");
                }
                else
                {
                    Matrix<T> finalMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
                    for (int rows = 0; rows < firstMatrix.Row; rows++)
                    {
                        for (int cols = 0; cols < firstMatrix.Col; cols++)
                        {
                            finalMatrix[rows, cols] = (dynamic)firstMatrix[rows, cols] - secondMatrix[rows, cols];
                        }
                    }
                    return finalMatrix;
                }
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (CheckForZeroElements(firstMatrix) || CheckForZeroElements(secondMatrix))
            {
                throw new Exception("There is empty or null values in the matrix");
            }
            else
            {
                if (firstMatrix.Row != secondMatrix.Row || firstMatrix.Col != secondMatrix.Col)
                {
                    throw new Exception("The matrixs must be with the same size, to be added");
                }
                else
                {
                    Matrix<T> finalMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
                    for (int rows = 0; rows < firstMatrix.Row; rows++)
                    {
                        for (int cols = 0; cols < firstMatrix.Col; cols++)
                        {
                            finalMatrix[rows, cols] = (dynamic)firstMatrix[rows, cols] * secondMatrix[rows, cols];
                        }
                    }
                    return finalMatrix;
                }
            }
        }

        private static bool CheckForZeroElements(Matrix<T> matrix)
        {
            for (int rows = 0; rows < matrix.Row; rows++)
            {
                for (int cols = 0; cols < matrix.Col; cols++)
                {
                    if (matrix[rows, cols] == null || (dynamic)matrix[rows, cols] == 0)
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }

    }
}

