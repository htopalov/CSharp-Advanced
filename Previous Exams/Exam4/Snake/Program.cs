using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int snakeRow = 0;
            int snakeCol = 0;
            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            int food = 0;
            while (true)
            {
                matrix[snakeRow, snakeCol] = '.';
                snakeRow = MoveRow(command, snakeRow);
                snakeCol = MoveCol(command, snakeCol);
                if (!isOut(snakeRow, snakeCol, n, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (matrix[snakeRow, snakeCol] == '*')
                {
                    food += 1;
                }
                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'B')
                            {
                                matrix[row, col] = 'S';
                                snakeRow = row;
                                snakeCol = col;
                            }
                        }
                    }
                }

                matrix[snakeRow, snakeCol] = 'S';
                if (food >= 10)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (food >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {food}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static bool isOut(int snakeRow, int snakeCol, int matrixRows, int matrixCols)
        {
            if (snakeRow >= matrixRows || snakeRow < 0)
            {
                return false;
            }
            if (snakeCol >= matrixCols || snakeCol < 0)
            {
                return false;
            }
            return true;
        }
        public static int MoveRow(string direction, int row)
        {
            if (direction == "up")
            {
                return row - 1;
            }
            else if (direction == "down")
            {
                return row + 1;
            }
            return row;
        }
        public static int MoveCol(string direction, int col)
        {
            if (direction == "left")
            {
                return col - 1;
            }
            else if (direction == "right")
            {
                return col + 1;
            }
            return col;
        }
    }
}
