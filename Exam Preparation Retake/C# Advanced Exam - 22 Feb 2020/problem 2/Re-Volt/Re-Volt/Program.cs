using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int commandsCount = int.Parse(Console.ReadLine());
            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool isFinished = false;

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();
                matrix[playerRow, playerCol] = '-';
                playerRow = MoveRow(command, playerRow);
                playerCol = MoveCol(command, playerCol);
                if (!isOut(playerRow,playerCol,matrix.GetLength(0),matrix.GetLength(1)))
                {
                    if (playerRow > matrix.GetLength(0) - 1)
                    {
                        playerRow = 0;
                    }
                    else if (playerRow < 0)
                    {
                        playerRow = matrix.GetLength(0) - 1;
                    }
                    if (playerCol > matrix.GetLength(1) - 1)
                    {
                        playerCol = 0;
                    }
                    else if (playerCol < 0)
                    {
                        playerCol = matrix.GetLength(1) - 1;
                    }
                }

                if (matrix[playerRow,playerCol] == 'B')
                {
                    playerRow = MoveRow(command, playerRow);
                    playerCol = MoveCol(command, playerCol);

                    if (!isOut(playerRow, playerCol, matrix.GetLength(0), matrix.GetLength(1)))
                    {
                        if (playerRow > matrix.GetLength(0) - 1)
                        {
                            playerRow = 0;
                        }
                        else if (playerRow < 0)
                        {
                            playerRow = matrix.GetLength(0) - 1;
                        }
                        if (playerCol > matrix.GetLength(1) - 1)
                        {
                            playerCol = 0;
                        }
                        else if (playerCol < 0)
                        {
                            playerCol = matrix.GetLength(1) - 1;
                        }
                    }

                }
                if (matrix[playerRow,playerCol] == 'T')
                {
                    if (command == "left")
                    {
                        command = "right";
                    }
                    else if (command == "right")
                    {
                        command = "left";
                    }
                    else if (command == "up")
                    {
                        command = "down";
                    }
                    else if (command == "down")
                    {
                        command = "up";
                    }
                    playerRow = MoveRow(command, playerRow);
                    playerCol = MoveCol(command, playerCol);
                }
                if (matrix[playerRow,playerCol] == 'F')
                {
                    isFinished = true;
                    matrix[playerRow, playerCol] = 'f';
                    break;
                }

                matrix[playerRow, playerCol] = 'f';
            }


            if (isFinished)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }




        public static bool isOut(int playerRow, int playerCol, int matrixRows, int matrixCols)
        {
            if (playerRow >= matrixRows || playerRow < 0)
            {
                return false;
            }
            if (playerCol >= matrixCols || playerCol < 0)
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
