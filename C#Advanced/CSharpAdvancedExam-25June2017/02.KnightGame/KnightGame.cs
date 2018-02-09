using System;

namespace _02.KnightGame
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
        
            var matrix = new char[n, n];
        
            matrix = FillMatrix(matrix, n);
        
        
            Console.WriteLine(KnightsRemover(matrix, n));
        }
        
        private static int KnightsRemover(char[,] matrix, int n)
        {
            var knightsRemovedCounter = 0;
            var maxCounter = 0;
            var row = 0;
            var col = 0;
            var counter = 0;
        
            while (true)
            {
                for (int indexRow = 0; indexRow < n; indexRow++)
                {
                    for (int indexCol = 0; indexCol < n; indexCol++)
                    {
                        counter = 0;
        
                        if (matrix[indexRow, indexCol] == 'K')
                        {
                            if (indexRow - 1 >= 0 && indexCol + 2 <= n - 1
                                && matrix[indexRow - 1, indexCol + 2] == 'K')
                            {
                                counter++;
                            }
        
                            if (indexRow - 1 >= 0 && indexCol - 2 >= 0
                                && matrix[indexRow - 1, indexCol - 2] == 'K')
                            {
                                counter++;
                            }
        
                            if (indexRow + 2 <= n - 1 && indexCol - 1 >= 0
                                && matrix[indexRow + 2, indexCol - 1] == 'K')
                            {
                                counter++;
                            }
        
                            if (indexRow + 2 <= n - 1 && indexCol + 1 <= n - 1
                                && matrix[indexRow + 2, indexCol + 1] == 'K')
                            {
                                counter++;
                            }
        
                            if (indexRow - 2 >= 0 && indexCol - 1 >= 0
                                && matrix[indexRow - 2, indexCol - 1] == 'K')
                            {
                                counter++;
                            }
        
                            if (indexRow - 2 >= 0 && indexCol + 1 <= n - 1
                                && matrix[indexRow - 2, indexCol + 1] == 'K')
                            {
                                counter++;
                            }
        
                            if (indexRow + 1 <= n - 1 && indexCol + 2 <= n - 1
                                && matrix[indexRow + 1, indexCol + 2] == 'K')
                            {
                                counter++;
                            }
        
                            if (indexRow + 1 <= n - 1 && indexCol - 2 >= 0
                                && matrix[indexRow + 1, indexCol - 2] == 'K')
                            {
                                counter++;
                            }
        
                            if (maxCounter < counter)
                            {
                                maxCounter = counter;
                                row = indexRow;
                                col = indexCol;
                            }
                        }
                    }
                }
                if (maxCounter == 0)
                {
                    break;
                }
                matrix[row, col] = '0';
                knightsRemovedCounter++;
                maxCounter = 0;
            }
            return knightsRemovedCounter;
        }
        
        private static char[,] FillMatrix(char[,] matrix, int n)
        {
            for (int indexRow = 0; indexRow < n; indexRow++)
            {
                var input = Console.ReadLine().ToCharArray();
                var counter = 0;
        
                for (int indexCol = 0; indexCol < n; indexCol++)
                {
                    matrix[indexRow, indexCol] = input[counter];
                    counter++;
                }
            }
        
            return matrix;
        }
    }
}
