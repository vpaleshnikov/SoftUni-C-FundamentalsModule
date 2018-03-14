using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new []{" "},StringSplitOptions.RemoveEmptyEntries);

            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[0]);

            var matrix = new int[rows, cols];

            FillMatrix(matrix);

            var primaryDiagonal = GetPrimaryDiagonal(matrix);
            var secondaryDiagonal = GetSecondaryDiagonal(matrix);

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }

        private static int GetSecondaryDiagonal(int[,] matrix)
        {
            var secondaryDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    secondaryDiagonal += matrix[row, col];
                    row++;
                }
            }

            return secondaryDiagonal;
        }

        private static int GetPrimaryDiagonal(int[,] matrix)
        {
            var primaryDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    primaryDiagonal += matrix[row, col];
                    row++;
                }
            }

            return primaryDiagonal;
        }

        private static void FillMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int rowidIndex = 0; rowidIndex < rows; rowidIndex++)
            {
                var numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowidIndex, colIndex] = numbers[colIndex];
                }
            }
        }
    }
}