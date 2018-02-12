using System;
using System.Linq;

namespace _02.JediGalaxy
{
    class JediGalaxy
    {
        static void Main(string[] args)
        {
            long ivoStarValue = 0;


            var matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var matrix = new int[matrixDimensions[0], matrixDimensions[1]];

            FillMatrix(matrix);

            string ivoInputCoordinates = Console.ReadLine();           

            while (ivoInputCoordinates != "Let the Force be with you")
            {
                string evilInputCoordinates = Console.ReadLine();

                var ivoParsedCoordinates = ivoInputCoordinates
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var evilParsedCoordinates = evilInputCoordinates
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var ivoCurrentRow = ivoParsedCoordinates[0];
                var ivoCurrentCol = ivoParsedCoordinates[1];

                var evilCurrentRow = evilParsedCoordinates[0];
                var evilCurrentCol = evilParsedCoordinates[1];

                while (evilCurrentRow >= 0 && evilCurrentCol >= 0)
                {
                    if (IsInMatrix(matrix, evilCurrentRow, evilCurrentCol))
                    {
                        matrix[evilCurrentRow, evilCurrentCol] = 0;
                    }

                    evilCurrentRow--;
                    evilCurrentCol--;
                }

                while (ivoCurrentRow >= 0 && ivoCurrentCol < matrix.GetLength(1))
                {
                    if (IsInMatrix(matrix, ivoCurrentRow, ivoCurrentCol))
                    {
                        ivoStarValue += matrix[ivoCurrentRow, ivoCurrentCol];
                    }

                    ivoCurrentRow--;
                    ivoCurrentCol++;
                }

                ivoInputCoordinates = Console.ReadLine();
            }
            Console.WriteLine(ivoStarValue);
        }

        private static bool IsInMatrix(int[,] matrix, int givenRow, int givenCol)
        {
            return givenRow >= 0 
                && givenRow < matrix.GetLength(0)
                && givenCol >= 0
                && givenCol < matrix.GetLength(1);
        }

        private static void FillMatrix(int[,] matrix)
        {
            int currentCount = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentCount;
                    currentCount++;
                }
            }
        }
    }
}
