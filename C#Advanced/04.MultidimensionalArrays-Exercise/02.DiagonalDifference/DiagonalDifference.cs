using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var primaryDiagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        primaryDiagonalSum += matrix[row + i, col + i];
                    }
                    break;
                }
                break;
            }

            var secondaryDiagonalSum = 0;
            for (int row = n - 1; row > 0; row--)
            {
                for (int col = 0; col < n; col++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        secondaryDiagonalSum += matrix[row - i, col + i];
                    }
                    break;
                }
                break;
            }

            var diff = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(diff);
        }
    }
}