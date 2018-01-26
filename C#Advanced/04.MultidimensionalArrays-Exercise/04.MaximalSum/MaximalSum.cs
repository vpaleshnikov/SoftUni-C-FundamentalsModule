using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = rowsCols[0];
            var cols = rowsCols[1];

            var matrix = new int[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            
            var maxSum = int.MinValue;
            var maxRow = 0;
            var maxCol = 0;

            var result = new List<int>();

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var sum = 
                          matrix[row, col]     + matrix[row + 1, col]     + matrix[row + 2, col]
                        + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1]
                        + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];
                    
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine("{0} {1} {2}",matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2]);
        }
    }
}