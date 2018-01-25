using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(input[0]);
            var columns = int.Parse(input[1]);

            int[,] matrix = new int[rows, columns];

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

            int sum = 0;

            for (int rowsCounter = 0; rowsCounter < matrix.GetLength(0); rowsCounter++)
            {
                for (int colsCounter = 0; colsCounter < matrix.GetLength(1); colsCounter++)
                {
                    sum += matrix[rowsCounter, colsCounter];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}