using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int sellerRow = 0;
            int sellerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string rowInput = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (matrix[row, col] == 'S')
                    {
                        sellerRow = row;
                        sellerCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            int totalMoney = 0;
            while (command != "End")
            {
                matrix[sellerRow, sellerCol] = '-';
                sellerRow = MoveRow(command, sellerRow);
                sellerCol = MoveCol(command, sellerCol);
                if (!isOut(sellerRow, sellerCol, n, n))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }
                if (char.IsDigit(matrix[sellerRow, sellerCol]))
                {
                    totalMoney += (int)char.GetNumericValue(matrix[sellerRow, sellerCol]);
                }
                if (matrix[sellerRow, sellerCol] == 'O')
                {
                    matrix[sellerRow, sellerCol] = '-';
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'O')
                            {
                                matrix[row, col] = 'S';
                                sellerRow = row;
                                sellerCol = col;
                            }
                        }
                    }
                }
                matrix[sellerRow, sellerCol] = 'S';
                if (totalMoney >= 50)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (totalMoney >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {totalMoney}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
        public static bool isOut(int sellerRow, int sellerCol, int matrixRows, int matrixCols)
        {
            if (sellerRow >= matrixRows || sellerRow < 0)
            {
                return false;
            }
            if (sellerCol >= matrixCols || sellerCol < 0)
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
