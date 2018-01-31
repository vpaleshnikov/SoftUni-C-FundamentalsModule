using System;
using System.Linq;

namespace _06.TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var textToFill = Console.ReadLine();

            char[,] matrix = FillSnake(dimensions, textToFill);

            var shotParameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            var shootedMatrix = ShotElements(matrix, shotParameters);

            Console.WriteLine();

        }

        private static char[,] ShotElements(char[,] matrix, string[] shotParameters)
        {
            var impactRow = int.Parse(shotParameters[0]);
            var impactColumn = int.Parse(shotParameters[1]);
            var impactRadius = int.Parse(shotParameters[2]);
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row - impactRow) * (row - impactRow) + (col - impactColumn) * (col - impactColumn) <= impactRadius * impactRadius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }

            return matrix;

        }

        private static char[,] FillSnake(string[] rowsCols, string text)
        {
            var rows = int.Parse(rowsCols[0]);
            var cols = int.Parse(rowsCols[1]);

            var matrix = new char[rows, cols];

            var stringToChar = text.ToCharArray();

            var charArrayPosition = 0;
            var checker = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                checker++;
                if (checker % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = stringToChar[charArrayPosition];
                        charArrayPosition++;

                        if (charArrayPosition == stringToChar.Length)
                        {
                            charArrayPosition = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = stringToChar[charArrayPosition];
                        charArrayPosition++;

                        if (charArrayPosition == stringToChar.Length)
                        {
                            charArrayPosition = 0;
                        }
                    }
                }
            }

            return matrix;
        }
    }
}