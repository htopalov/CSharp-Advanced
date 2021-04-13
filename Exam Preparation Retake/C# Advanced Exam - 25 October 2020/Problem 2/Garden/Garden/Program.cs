using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            List<int[]> coordinates = new List<int[]>();
            string command = Console.ReadLine();
            while (command != "Bloom Bloom Plow")
            {
                int[] position = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int rowPlant = position[0];
                int colPlant = position[1];
                if (!isOut(rowPlant,colPlant,matrix.GetLength(0), matrix.GetLength(1)))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    for (int row = rowPlant; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, colPlant]++;
                    }
                    for (int row = rowPlant - 1; row >= 0; row--)
                    {
                        matrix[row, colPlant]++;
                    }
                    for (int col = colPlant + 1; col < matrix.GetLength(1); col++)
                    {
                        matrix[rowPlant, col]++;
                    }
                    for (int col = colPlant - 1; col >= 0; col--)
                    {
                        matrix[rowPlant, col]++;
                    }
                }

                command = Console.ReadLine();
            }




            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool isOut(int rowPlant, int colPlant, int matrixRows, int matrixCols)
        {
            if (rowPlant >= matrixRows || rowPlant < 0)
            {
                return false;
            }
            if (colPlant >= matrixCols || colPlant < 0)
            {
                return false;
            }
            return true;
        }
    }
}
