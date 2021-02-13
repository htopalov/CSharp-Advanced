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
            int pollinatedFlowersCount = 0;
            while (command != "End")
            {
                switch (command)
                {

                }
                command = Console.ReadLine();
            }
        }
    }
}
