using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                list.Add(input);
            }
            Box<double> box = new Box<double>(list);
            string valueToCompare = Console.ReadLine();
            Console.WriteLine(box.Comparator(Convert.ToDouble(valueToCompare)));

        }
    }
}