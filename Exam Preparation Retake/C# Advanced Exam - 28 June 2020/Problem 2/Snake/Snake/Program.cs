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
            int foodQuantity = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row,col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            while (true)
            {
                matrix[snakeRow, snakeCol] = '.';
                snakeRow = MoveRow(command, snakeRow);
                snakeCol = MoveCol(command, snakeCol);
                if (!isOut(snakeRow,snakeCol,matrix.GetLength(0),matrix.GetLength(1)))
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (matrix[snakeRow,snakeCol] == '*')
                {
                    foodQuantity++;

                }
                if (matrix[snakeRow,snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (matrix[row,col] == 'B')
                            {
                                matrix[row, col] = 'S';
                                snakeRow = row;
                                snakeCol = col;        
                            }
                        }
                    }
                }

                matrix[snakeRow, snakeCol] = 'S';
                if (foodQuantity >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");



            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
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




        public static int MoveRow(string direction, int snakeRow)
        {
            if (direction == "up")
            {
                return snakeRow - 1;
            }
            else if (direction == "down")
            {
                return snakeRow + 1;
            }
            return snakeRow;
        }




        public static int MoveCol(string direction, int snakeCol)
        {
            if (direction == "left")
            {
                return snakeCol - 1;
            }
            else if (direction == "right")
            {
                return snakeCol + 1;
            }
            return snakeCol;
        }
    }
}
