using System;
using System.Linq;

namespace _08.RadioactiveBunnies
{
    class RadioactiveBunnies
    {
        static char[,] board;
        static int playerRow;
        static int playerCol;
        static int rows;
        static int colums;

        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            board = FillMatrix(dimensions);

            var movements = Console.ReadLine().ToCharArray();

            foreach (char move in movements)
            {
                int[] previousLocation = MovePlayer(move);
            
                MultiplyBunnies();

                if (isPlayerOnBoard())
                {
                    if (board[playerRow, playerCol] == 'B')
                    {
                        Die();
                    }
                    continue;
                }

                Win(previousLocation);
            }  
            
        }

        private static void Die()
        {
            PrintBoard();

            Console.WriteLine($"dead: {playerRow} {playerCol}");

            Environment.Exit(0);
        }

        private static void Win(int[] previousLocation)
        {
            int winRow = previousLocation[0];
            int winCol = previousLocation[1];

            PrintBoard();

            Console.WriteLine($"won: {winRow} {winCol}");

            Environment.Exit(0);
        }

        private static bool isPlayerOnBoard()
        {
            bool isValidRow = playerRow >= 0 && playerRow < rows;
            bool isValidCol = playerCol >= 0 && playerCol < colums;

            if (isValidRow && isValidCol)
            {
                return true;
            }
            return false;
        }

        private static void PrintBoard()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < colums; col++)
                {
                    Console.Write(board[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void MultiplyBunnies()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < colums; col++)
                {
                    if (board[row,col] == 'B')
                    {
                        if (row > 0)
                        {
                            NewBunny(row - 1, col);
                        }
                        if (row < rows - 1)
                        {
                            NewBunny(row + 1, col);
                        }
                        if (col > 0)
                        {
                            NewBunny(row, col - 1);
                        }
                        if (col < colums - 1)
                        {
                            NewBunny(row, col + 1);
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < colums; col++)
                {
                    if (board[row,col] == 'X')
                    {
                        board[row, col] = 'B';
                    }
                }
            }
        }

        private static void NewBunny(int row, int col)
        {
            if (board[row, col] != 'B')
            {
                board[row, col] = 'X';
            }
        }

        private static int[] MovePlayer(char move)
        {
            int[] previousLocation = { playerRow, playerCol };

            if (move == 'U')
            {
                playerRow--;
            }
            else if (move == 'D')
            {
                playerRow++;
            }
            else if (move == 'L')
            {
                playerCol--;
            }
            else if (move == 'R')
            {
                playerCol++;
            }

            if (isPlayerOnBoard() && board[playerRow, playerCol] != 'B')
            {
                board[playerRow, playerCol] = 'P';
            }

            int oldRow = previousLocation[0];
            int oldCol = previousLocation[1];

            board[oldRow, oldCol] = '.';

            return previousLocation;
        }

        private static char[,] FillMatrix(int[] dimensions)
        {
            rows = dimensions[0];
            colums = dimensions[1];

            var matrix = new char[rows, colums];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < colums; col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            return matrix;

        }
    }
}