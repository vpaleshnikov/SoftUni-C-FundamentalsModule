using System;
using System.Linq;

namespace _03.SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = input[0];
            var cols = input[1];

            var matrix = new char[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                var charInput = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = charInput[col];
                }
            }

            var counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row,col] == matrix[row,col + 1] 
                        && matrix[row,col] == matrix[row + 1, col]
                        && matrix[row,col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}