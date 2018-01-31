using System;

namespace _05.RubiksMatrix
{
    class RubiksMatrix
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);
            var n = int.Parse(Console.ReadLine());

            var matrix = new int[rows, cols];

            matrix = FillMatrix(rows, cols);

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[1] == "up")
                {
                    MoveUp(matrix, command);
                }
                else if (command[1] == "down")
                {
                    MoveDown(matrix, command);
                }
                else if (command[1] == "left")
                {
                    MoveLeft(matrix, command);
                }
                else if (command[1] == "right")
                {
                    MoveRight(matrix, command);
                }
            }

            RearangeMatrix(matrix);
        }

        private static void RearangeMatrix(int[,] matrix)
        {
            int row = 0;
            int col = 0;

            var checker = 1;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows,cols] == checker)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < matrix.GetLength(0); r++)
                        {
                            for (int c = 0; c < matrix.GetLength(1); c++)
                            {
                                if (matrix[r, c] == checker)
                                {
                                    row = r;
                                    col = c;

                                    Console.WriteLine($"Swap ({rows}, {cols}) with ({r}, {c})");
                                    var temp = matrix[rows, cols];
                                    matrix[rows, cols] = matrix[r, c];
                                    matrix[r, c] = temp;
                                    break;
                                }
                            }
                        }
                    }
                    checker++;
                }
            }
        }

        private static void MoveRight(int[,] matrix, string[] command)
        {
            var row = int.Parse(command[0]);
            var moves = int.Parse(command[2]);

            for (int cols = 0; cols < moves % matrix.GetLength(1); cols++)
            {
                var lastElement = matrix[row, matrix.GetLength(1) - 1];

                for (int i = matrix.GetLength(0) - 1; i > 0 ; i--)
                {
                    matrix[row, i] = matrix[row, i - 1];
                }

                matrix[row, 0] = lastElement;
            }
        }

        private static void MoveLeft(int[,] matrix, string[] command)
        {
            var row = int.Parse(command[0]);
            var moves = int.Parse(command[2]);

            for (int cols = 0; cols < moves % matrix.GetLength(1); cols++)
            {
                var firstElement = matrix[row, cols];

                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    matrix[row, i] = matrix[row, i + 1];
                }

                matrix[row, matrix.GetLength(1) - 1] = firstElement;
            }
        }

        private static void MoveDown(int[,] matrix, string[] command)
        {
            var column = int.Parse(command[0]);
            var moves = int.Parse(command[2]);

            for (int rows = 0; rows < moves % matrix.GetLength(0); rows++)
            {
                var bottomElement = matrix[matrix.GetLength(0) - 1, column];

                for (int i = matrix.GetLength(1) - 1; i > 0 ; i--)
                {
                    matrix[i, column] = matrix[i - 1, column];
                }

                matrix[rows, column] = bottomElement;
            }
        }

        private static void MoveUp(int[,] matrix, string[] command)
        {
            var column = int.Parse(command[0]);
            var moves = int.Parse(command[2]);

            for (int i = 0; i < moves % matrix.GetLength(0); i++)
            {
                var topElement = matrix[0, column];

                for (int rows = 0; rows < matrix.GetLength(1) - 1; rows++)
                {
                    matrix[rows, column] = matrix[rows + 1, column];
                }

                matrix[matrix.GetLength(0) - 1, column] = topElement;
            }
        }

        private static int[,] FillMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];

            var counter = 1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }

            return matrix;
        }
    }
}