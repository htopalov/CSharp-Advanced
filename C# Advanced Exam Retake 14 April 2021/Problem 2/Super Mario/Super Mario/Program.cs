using System;

namespace Super_Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            var matrix = new char[sizeOfMatrix][];

            int marioRow = int.MinValue;
            int marioCol = int.MinValue;

            for (int row = 0; row < matrix.Length; row++)
            {
                string currentRow = Console.ReadLine();
                int length = currentRow.Length;
                matrix[row] = new char[length];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = currentRow[col];

                    if (currentRow[col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }


            matrix[marioRow][marioCol] = '-';

            while (true)
            {
                var bowserSpawn = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string marioDirection = bowserSpawn[0];
                int bowserRow = int.Parse(bowserSpawn[1]);
                int bowserCol = int.Parse(bowserSpawn[2]);

                matrix[bowserRow][bowserCol] = 'B';

                if (marioDirection == "W")
                {
                    if (marioRow - 1 >= 0)
                    {
                        marioRow--;
                        marioLives--;

                        if (marioLives <= 0)
                        {
                            matrix[marioRow][marioCol] = 'X';
                            Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                            break;
                        }
                    }
                    else if (marioRow - 1 < 0)
                    {
                        marioLives--;
                        if (marioLives <= 0)
                        {
                            matrix[marioRow][marioCol] = 'X';
                            Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                            break;
                        }
                    }
                }
                else if (marioDirection == "S")
                {
                    if (marioRow + 1 < sizeOfMatrix)
                    {
                        marioRow++;
                        marioLives--;

                        if (marioLives <= 0)
                        {
                            matrix[marioRow][marioCol] = 'X';
                            Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                            break;
                        }
                    }
                    else if (marioRow + 1 >= sizeOfMatrix)
                    {
                        marioLives--;
                        if (marioLives <= 0)
                        {
                            matrix[marioRow][marioCol] = 'X';
                            Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                            break;
                        }
                    }
                }
                else if (marioDirection == "A")
                {
                    if (marioCol - 1 >= 0)
                    {
                        marioCol--;
                        marioLives--;

                        if (marioLives <= 0)
                        {
                            matrix[marioRow][marioCol] = 'X';
                            Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                            break;
                        }
                    }
                    else if (marioCol - 1 < 0)
                    {
                        marioLives--;
                        if (marioLives <= 0)
                        {
                            matrix[marioRow][marioCol] = 'X';
                            Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                            break;
                        }
                    }
                }
                else if (marioDirection == "D")
                {
                    if (marioCol + 1 < sizeOfMatrix)
                    {
                        marioCol++;
                        marioLives--;

                        if (marioLives <= 0)
                        {
                            matrix[marioRow][marioCol] = 'X';
                            Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                            break;
                        }
                    }
                }
                else if (marioCol + 1 >= sizeOfMatrix)
                {
                    marioLives--;
                    if (marioLives <= 0)
                    {
                        matrix[marioRow][marioCol] = 'X';
                        Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                        break;
                    }
                }

                if (matrix[marioRow][marioCol] == 'P')
                {
                    matrix[marioRow][marioCol] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioLives}");
                    break;
                }

                if (matrix[marioRow][marioCol] == 'B')
                {
                    marioLives -= 2;
                    if (marioLives > 0)
                    {
                        matrix[marioRow][marioCol] = '-';
                    }
                    else
                    {
                        matrix[marioRow][marioCol] = 'X';
                        Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                        break;
                    }
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }

                Console.WriteLine();
            }
        }

    }
}
