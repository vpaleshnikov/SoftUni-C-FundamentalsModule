using System;
using System.Linq;

namespace _07.LegoBlocks
{
    class LegoBlocks
    {
        public static long totalSells = 0;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstMatrix = new string[n][];
            var secondMatrix = new string[n][];

            FillMatrix(firstMatrix, n);
            FillMatrix(secondMatrix, n);

            for (int rowIndex = 0; rowIndex < secondMatrix.Length; rowIndex++)
            {
                Array.Reverse(secondMatrix[rowIndex]);
            }

            var newMatrix = new string[n][];

            for (int rowIndex = 0; rowIndex < n; rowIndex++)
            {
                newMatrix[rowIndex] = firstMatrix[rowIndex].Concat(secondMatrix[rowIndex]).ToArray();
            }

            var isFit = true;

            for (int rowIndex = 0; rowIndex < newMatrix.Length - 1; rowIndex++)
            {
                if (newMatrix[rowIndex].Length != newMatrix[rowIndex + 1].Length)
                {
                    isFit = false;
                    break;
                }
            }

            if (isFit)
            {
                for (int rowIndex = 0; rowIndex < n; rowIndex++)
                {
                    Console.WriteLine($"[{string.Join(", ", firstMatrix[rowIndex].Concat(secondMatrix[rowIndex]))}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalSells}");
            }
        }

        private static void FillMatrix(string[][] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                totalSells += matrix[i].Length;                
            }
        }
    }
}