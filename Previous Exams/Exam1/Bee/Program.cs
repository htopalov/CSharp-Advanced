using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] territory = new char[n, n];
            int beeRow = 0;
            int beeCol = 0;
            for (int row = 0; row < territory.GetLength(0); row++)
            {
                string inputData = Console.ReadLine();
                for (int col = 0; col < territory.GetLength(1); col++)
                {
                    if (inputData[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                    territory[row, col] = inputData[col];
                }
            }
            string command = Console.ReadLine();
            int pollinatedCount = 0;
            while (command != "End")
            {
                territory[beeRow, beeCol] = '.';
                beeRow = BeeMoveRow(command, beeRow);
                beeCol = BeeMoveCol(command, beeCol);
                if (!isLost(beeRow, beeCol, n, n))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                if (territory[beeRow, beeCol] == 'f')
                {
                    pollinatedCount++;
                }
                if (territory[beeRow, beeCol] == 'O')
                {
                    territory[beeRow, beeCol] = '.';
                    beeRow = BeeMoveRow(command, beeRow);
                    beeCol = BeeMoveCol(command, beeCol);
                    if (territory[beeRow, beeCol] == 'f')
                    {
                        pollinatedCount++;
                    }
                }
                territory[beeRow, beeCol] = 'B';
                command = Console.ReadLine();
            }
            if (pollinatedCount < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedCount} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedCount} flowers!");
            }
            for (int row = 0; row < territory.GetLength(0); row++)
            {
                for (int col = 0; col < territory.GetLength(1); col++)
                {
                    Console.Write(territory[row, col]);
                }
                Console.WriteLine();
            }
        }
        public static bool isLost(int beeRow, int beeCol, int territoryRows, int territoryCols)
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
        public static int BeeMoveRow(string direction, int row)
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
        public static int BeeMoveCol(string direction, int col)
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
