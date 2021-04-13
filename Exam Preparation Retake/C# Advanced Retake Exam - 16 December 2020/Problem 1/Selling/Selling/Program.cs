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
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row,col] == 'S')
                    {
                        sellerRow = row;
                        sellerCol = col;
                    }
                }
            }
            int money = 0;
            string command = Console.ReadLine();
            while (true)
            {
                matrix[sellerRow, sellerCol] = '-';
                sellerRow = MoveRow(command, sellerRow);
                sellerCol = MoveCol(command, sellerCol);
                if (!isOut(sellerRow,sellerCol, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }
                if (char.IsDigit(matrix[sellerRow,sellerCol]))
                {
                    money += (int)char.GetNumericValue(matrix[sellerRow, sellerCol]);
                }
                if (matrix[sellerRow,sellerCol] == 'O')
                {
                    matrix[sellerRow, sellerCol] = '-';
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (matrix[row,col] == 'O')
                            {
                                sellerRow = row;
                                sellerCol = col;
                            }
                        }
                    }
                }
                matrix[sellerRow, sellerCol] = 'S';
                if (money >= 50)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (money >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {money}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
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
