using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowData.Length; col++)
                {
                    jaggedMatrix[row] = rowData;
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] arguments = command.Split();
                string action = arguments[0];
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);
                if (row >= 0 && col >= 0 && row < rows && col < jaggedMatrix[row].Length)
                {
                    switch (action)
                    {
                        case "Add":
                            jaggedMatrix[row][col] += value;
                            break;
                        case "Subtract":
                            jaggedMatrix[row][col] -= value;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    Console.Write(jaggedMatrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
