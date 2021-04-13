using System;
using System.Linq;

namespace Warship
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] coordinates = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            char[,] matrix = new char[n, n];

            int firstPlayerShips = 0;
            int secondPlayerShips = 0;
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row, col] == '<')
                    {
                        firstPlayerShips++;
                    }
                    if (matrix[row, col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }

            int firstPlayerShipsDestroyed = 0;
            int secondPlayerShipsDestroyed = 0;
            bool isFirstPlayerTurn = false;

            for (int i = 0; i < coordinates.Length; i++)
            {
                if (i % 2 == 0)
                {
                    isFirstPlayerTurn = true;
                }
                int[] currentCoordinates = coordinates[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int attackRow = currentCoordinates[0];
                int attackCol = currentCoordinates[1];
                if (isOut(attackRow, attackCol, matrix.GetLength(0), matrix.GetLength(1))) //not out of the field
                {
                    if (matrix[attackRow,attackCol] == '>')
                    {
                        secondPlayerShips--;
                        firstPlayerShipsDestroyed++;
                        matrix[attackRow, attackCol] = 'X';
                    }
                    if (matrix[attackRow,attackCol] == '<')
                    {
                        firstPlayerShips--;
                        secondPlayerShipsDestroyed++;
                        matrix[attackRow, attackCol] = 'X';
                    }
                    if (matrix[attackRow,attackCol] == '#')
                    {
                        matrix[attackRow, attackCol] = 'X';
                        //have to check for each cell around the mine is it in the field and what symbol is in it...
                        //up cell
                        int[] upCell = new int[2];
                        upCell[0] = attackRow - 1;
                        upCell[1] = attackCol;

                        if (isOut(upCell[0],upCell[1],matrix.GetLength(0),matrix.GetLength(1)))
                        {
                            if (matrix[upCell[0], upCell[1]] == '>')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    secondPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    secondPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                               
                            }
                            if (matrix[upCell[0], upCell[1]] == '<')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    firstPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    firstPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                                
                            }

                            matrix[upCell[0], upCell[1]] = 'X';
                        }

                        //down cell
                        int[] downCell = new int[2];
                        downCell[0] = attackRow + 1;
                        downCell[1] = attackCol;

                        if (isOut(downCell[0],downCell[1], matrix.GetLength(0),matrix.GetLength(1)))
                        {
                            if (matrix[downCell[0], downCell[1]] == '>')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    secondPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    secondPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                         
                            }
                            if (matrix[downCell[0], downCell[1]] == '<')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    firstPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    firstPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                            }

                            matrix[downCell[0], downCell[1]] = 'X';
                        }

                        //left cell

                        int[] leftCell = new int[2];
                        leftCell[0] = attackRow;
                        leftCell[1] = attackCol - 1;

                        if (isOut(leftCell[0],leftCell[1],matrix.GetLength(0),matrix.GetLength(1)))
                        {
                            if (matrix[leftCell[0], leftCell[1]] == '>')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    secondPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    secondPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                                
                            }
                            if (matrix[leftCell[0], leftCell[1]] == '<')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    firstPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    firstPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                            }

                            matrix[leftCell[0], leftCell[1]] = 'X';
                        }

                        //right cell
                        int[] rightCell = new int[2];
                        rightCell[0] = attackRow;
                        rightCell[1] = attackCol + 1;

                        if (isOut(rightCell[0],rightCell[1],matrix.GetLength(0),matrix.GetLength(1)))
                        {
                            if (matrix[rightCell[0], rightCell[1]] == '>')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    secondPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    secondPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                             
                            }
                            if (matrix[rightCell[0], rightCell[1]] == '<')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    firstPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    firstPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                              
                            }

                            matrix[rightCell[0], rightCell[1]] = 'X';
                        }


                        //left top corner
                        int[] leftTopCorner = new int[2];
                        leftTopCorner[0] = attackRow - 1;
                        leftTopCorner[1] = attackCol - 1;


                        if (isOut(leftTopCorner[0], leftTopCorner[1], matrix.GetLength(0), matrix.GetLength(1)))
                        {
                            if (matrix[leftTopCorner[0], leftTopCorner[1]] == '>')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    secondPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    secondPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                       
                            }
                            if (matrix[leftTopCorner[0], leftTopCorner[1]] == '<')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    firstPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    firstPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                            }

                            matrix[leftTopCorner[0], leftTopCorner[1]] = 'X';
                        }

                        //right top corner

                        int[] rightTopCorner = new int[2];
                        rightTopCorner[0] = attackRow - 1;
                        rightTopCorner[1] = attackCol + 1;


                        if (isOut(rightTopCorner[0], rightTopCorner[1], matrix.GetLength(0), matrix.GetLength(1)))
                        {
                            if (matrix[rightTopCorner[0], rightTopCorner[1]] == '>')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    secondPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    secondPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                           
                            }
                            if (matrix[rightTopCorner[0], rightTopCorner[1]] == '<')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    firstPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    firstPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                            }

                            matrix[rightTopCorner[0], rightTopCorner[1]] = 'X';
                        }

                        //bottom left corner

                        int[] bottomLeftCorner = new int[2];
                        bottomLeftCorner[0] = attackRow + 1;
                        bottomLeftCorner[1] = attackCol - 1;

                        if (isOut(bottomLeftCorner[0], bottomLeftCorner[1], matrix.GetLength(0), matrix.GetLength(1)))
                        {
                            if (matrix[bottomLeftCorner[0], bottomLeftCorner[1]] == '>')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    secondPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    secondPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                         
                            }
                            if (matrix[bottomLeftCorner[0], bottomLeftCorner[1]] == '<')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    firstPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    firstPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                            }

                            matrix[bottomLeftCorner[0], bottomLeftCorner[1]] = 'X';
                        }

                        //bottom right corner
                        int[] bottomRightCorner = new int[2];
                        bottomRightCorner[0] = attackRow + 1;
                        bottomRightCorner[1] = attackCol + 1;

                        if (isOut(bottomRightCorner[0], bottomRightCorner[1], matrix.GetLength(0), matrix.GetLength(1)))
                        {
                            if (matrix[bottomRightCorner[0], bottomRightCorner[1]] == '>')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    secondPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    secondPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                            
                            }
                            if (matrix[bottomRightCorner[0], bottomRightCorner[1]] == '<')
                            {
                                if (isFirstPlayerTurn)
                                {
                                    firstPlayerShips--;
                                    firstPlayerShipsDestroyed++;
                                }
                                else
                                {
                                    firstPlayerShips--;
                                    secondPlayerShipsDestroyed++;
                                }
                            }

                            matrix[bottomRightCorner[0], bottomRightCorner[1]] = 'X';
                        }
                    }

                }

                if (firstPlayerShips == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {secondPlayerShipsDestroyed} ships have been sunk in the battle.");
                    break;
                }
                if (secondPlayerShips == 0)
                {
                    Console.WriteLine($"Player One has won the game! {firstPlayerShipsDestroyed} ships have been sunk in the battle.");
                    break;
                }
            }

            if (firstPlayerShips > 0 && secondPlayerShips > 0 )
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} left. Player Two has {secondPlayerShips} left.");
            }


        }
        public static bool isOut(int attackRow, int attackCol, int matrixRows, int matrixCols)
        {
            if (attackRow >= matrixRows || attackRow < 0)
            {
                return false;
            }
            if (attackCol >= matrixCols || attackCol < 0)
            {
                return false;
            }
            return true;
        }


    }
}
