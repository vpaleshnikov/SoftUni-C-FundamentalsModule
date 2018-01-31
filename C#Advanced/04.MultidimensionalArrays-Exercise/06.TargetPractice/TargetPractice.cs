using System;

namespace _06.TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int numberOfRows = int.Parse(dimensions[0]);
            int numberOfColumns = int.Parse(dimensions[1]);

            var matrix = new char[numberOfRows, numberOfColumns];

            string snake = Console.ReadLine();

            FillMatrix(matrix, snake, numberOfRows, numberOfColumns);

            var shots = Console.ReadLine().Split();
            var impactRow = int.Parse(shots[0]);
            var impactCol = int.Parse(shots[1]);
            var radius = int.Parse(shots[2]);

            ShotElements(matrix,impactRow,impactCol,radius);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                DropElements(matrix, col);
            }

            PrintMatrix(matrix);
        }

        private static void DropElements(char[,] matrix, int col)
        {
            while (true)
            {
                var hasFallen = false;

                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    var topElement = matrix[row - 1, col];
                    var currentChar = matrix[row, col];
                    if (currentChar == ' ' && topElement != ' ')
                    {
                        matrix[row, col] = topElement;
                        matrix[row - 1, col] = ' ';
                        hasFallen = true;
                    }
                }
                if (!hasFallen)
                {
                    break;
                }
            }
        }

        private static void ShotElements(char[,] matrix, int impactRow, int impactCol, int radius)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((col - impactCol) * (col - impactCol) + (row - impactRow) * (row - impactRow) <= radius * radius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
                {
                    Console.Write($"{matrix[rowIndex,colIndex]}");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(char[,] matrix, string snake, int numberOfRows, int numberOfColumns)
        {
            var currentIndex = 0;

            var isMovingLeft = true;

            for (int row = numberOfRows - 1; row >= 0; row--)
            {
                if (isMovingLeft)
                {
                    for (int col = numberOfColumns - 1; col >= 0; col--)
                    {
                        //check if the index is valid
                        if (currentIndex >= snake.Length)
                        {
                            currentIndex = 0;
                        }

                        matrix[row, col] = snake[currentIndex];
                        currentIndex++;
                    }
                }
                else
                {
                    for (int col = 0; col < numberOfColumns; col++)
                    {
                        //check if the index is valid
                        if (currentIndex >= snake.Length)
                        {
                            currentIndex = 0;
                        }

                        matrix[row, col] = snake[currentIndex];
                        currentIndex++;
                    }
                }

                isMovingLeft = !isMovingLeft;
            }
        }
    }
}