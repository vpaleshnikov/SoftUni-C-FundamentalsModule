using System;
using System.Linq;

namespace _02.SquareWithMaximumSum
{
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(input[0]);
            var columns = int.Parse(input[1]);

            int[,] matrix = new int[rows, columns];

            var firstRowIndex = 0;
            var secondRowIndex = 0;
            var firstColIndex = 0;
            var secondColIndex = 0;

            int maxSum = int.MinValue;

            for (int rowsCounter = 0; rowsCounter < rows; rowsCounter++)
            {
                var rowsValues = Console.ReadLine()
                           .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

                for (int colsCounter = 0; colsCounter < columns; colsCounter++)
                {
                    matrix[rowsCounter, colsCounter] = rowsValues[colsCounter];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var tempSum = 
                          matrix[row, col] 
                        + matrix[row, col + 1] 
                        + matrix[row + 1, col] 
                        + matrix[row + 1, col + 1];

                    if (maxSum < tempSum)
                    {
                        maxSum = tempSum;

                        firstRowIndex = matrix[row, col];
                        secondRowIndex = matrix[row + 1, col];
                        firstColIndex = matrix[row, col + 1];
                        secondColIndex = matrix[row + 1, col + 1];

                    }
                }
            }
            Console.WriteLine($"{firstRowIndex} {firstColIndex} ");
            Console.WriteLine($"{secondRowIndex} {secondColIndex} ");
            Console.WriteLine(maxSum);
        }
    }
}