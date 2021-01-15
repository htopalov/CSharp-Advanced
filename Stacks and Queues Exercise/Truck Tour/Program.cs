using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> circle = new Queue<string>();
            for (int i = 0; i < n; i++)
            {
                circle.Enqueue(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int currentFuel = 0;
                bool isSuccess = true;
                for (int j = 0; j < n; j++)
                {
                    string pumpDataStr = circle.Dequeue();
                    int[] pumpData = pumpDataStr.Split().Select(int.Parse).ToArray();
                    circle.Enqueue(pumpDataStr);

                    currentFuel += pumpData[0];
                    currentFuel -= pumpData[1];
                    if (currentFuel <0)
                    {
                        isSuccess = false;
                    }
                }
                if (isSuccess)
                {
                    Console.WriteLine(i);
                    break;
                }
                string temp = circle.Dequeue();
                circle.Enqueue(temp);
            }
        }
    }
}
