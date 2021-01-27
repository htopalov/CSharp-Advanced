using System;

namespace UsingOneFunctionToCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            Func<int, int, int> sum = (x, y) => x + y;
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine(Calculate(a, b, sum));
            Console.WriteLine(Calculate(a, b, multiply));
        }
        public static int Calculate(int a, int b, Func<int, int, int> ff)
        {
            return ff(a, b);
        }
    }
}
