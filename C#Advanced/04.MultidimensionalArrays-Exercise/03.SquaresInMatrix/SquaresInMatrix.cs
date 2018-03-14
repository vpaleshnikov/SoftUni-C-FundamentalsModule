using System;
using System.Linq;

namespace _03.SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split();

            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);

            var matrix = new string[rows, cols];

            FillMatrix(matrix);

            Console.WriteLine(EqualCharSquareFinder(matrix));
        }

        private static int EqualCharSquareFinder(string[,] matrix)
        {
            var counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row,col] == matrix[row, col + 1]
                        && matrix[row,col] == matrix[row+1,col]
                        && matrix[row,col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        private static void FillMatrix(string[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int rowidIndex = 0; rowidIndex < rows; rowidIndex++)
            {
                var input = Console.ReadLine().Split();

                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowidIndex, colIndex] = input[colIndex];
                }
            }
        }
    }
}