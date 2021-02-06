using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxs = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                boxs.Add(new Box<int>(Convert.ToInt32(input)));

            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(boxs, indexes[0], indexes[1]);
            for (int i = 0; i < boxs.Count; i++)
            {
                Console.WriteLine(boxs[i].ToString());
            }

        }
        static void Swap<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
