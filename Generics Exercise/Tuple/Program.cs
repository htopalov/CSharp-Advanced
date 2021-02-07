using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputFirst = Console.ReadLine().Split();
            string name = $"{inputFirst[0]} {inputFirst[1]}";
            MyTuple<string, string> myTuple = new MyTuple<string, string>(name, inputFirst[2]);
            Console.WriteLine(myTuple.ToString());
            string[] inputSecond = Console.ReadLine().Split();
            MyTuple<string, int> beerTuple = new MyTuple<string, int>(inputSecond[0], int.Parse(inputSecond[1]));
            Console.WriteLine(beerTuple.ToString());
            string[] inputThird = Console.ReadLine().Split();
            MyTuple<int, double> numberTuple = new MyTuple<int, double>(int.Parse(inputThird[0]), double.Parse(inputThird[1]));
            Console.WriteLine(numberTuple.ToString());
        }
    }
}