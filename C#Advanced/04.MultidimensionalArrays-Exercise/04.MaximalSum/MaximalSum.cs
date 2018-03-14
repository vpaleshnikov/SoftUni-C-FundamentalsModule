using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);

            var matrix = new int[rows, cols];

            FillMatrix(matrix);

            FindMaxSum(matrix);

        }

        private static void FindMaxSum(int[,] matrix)
        {
            var maxSum = int.MinValue;
            var row = 0;
            var col = 0;

            for (int rowIndex = 0; rowIndex < matrix.GetLength(0) - 2; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.GetLength(1) - 2; colIndex++)
                {
                    var sum = matrix[rowIndex, colIndex]
                              + matrix[rowIndex, colIndex + 1]
                              + matrix[rowIndex, colIndex + 2]
                              + matrix[rowIndex + 1, colIndex]
                              + matrix[rowIndex + 1, colIndex + 1]
                              + matrix[rowIndex + 1, colIndex + 2]
                              + matrix[rowIndex + 2, colIndex]
                              + matrix[rowIndex + 2, colIndex + 1] 
                              + matrix[rowIndex + 2, colIndex + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        row = rowIndex;
                        col = colIndex;

                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            PrintResultMatrix(matrix, row, col);
        }

        private static void PrintResultMatrix(int[,] matrix, int row, int col)
        {
            Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}");
            Console.WriteLine($"{matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}");
            Console.WriteLine($"{matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}");
        }

        private static void FillMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int rowidIndex = 0; rowidIndex < rows; rowidIndex++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowidIndex, colIndex] = input[colIndex];
                }
            }
		}
	}         
}