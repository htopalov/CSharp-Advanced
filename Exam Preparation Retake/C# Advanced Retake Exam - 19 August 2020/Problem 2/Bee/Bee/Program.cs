using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int beeRow = 0;
            int beeCol = 0;
            int flowersCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                matrix[beeRow, beeCol] = '.';

                beeRow = MoveRow(command, beeRow);
                beeCol =MoveCol(command, beeCol);

                if (!isOut(beeRow, beeCol, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                if (matrix[beeRow, beeCol] == 'f')
                {
                    flowersCount++;
                }
                if (matrix[beeRow, beeCol] == 'O')
                {
                    matrix[beeRow, beeCol] = '.';
                    beeRow = MoveRow(command, beeRow);
                    beeCol = MoveCol(command, beeCol);
                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowersCount++;
                    }
                }
                matrix[beeRow, beeCol] = 'B';

                command = Console.ReadLine();
            }
            if (flowersCount >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowersCount} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowersCount} flowers more");
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

        public static bool isOut(int beeRow, int beeCol, int territoryRows, int territoryCols)
        {
            if (beeRow >= territoryRows || beeRow < 0)
            {
                return false;
            }
            if (beeCol >= territoryCols || beeCol < 0)
            {
                return false;
            }
            return true;
        }
    }
}
