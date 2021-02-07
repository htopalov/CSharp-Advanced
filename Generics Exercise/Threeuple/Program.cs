using System;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            Threeuple<string, string, string> firstThreeple = new Threeuple<string, string, string>($"{firstInput[0]} {firstInput[1]}", firstInput[2], firstInput[3]);
            Console.WriteLine(firstThreeple.ToString());
            string[] secondInput = Console.ReadLine().Split();
            bool isDrunk = false;
            if (secondInput[2] == "drunk")
            {
                isDrunk = true;
            }
            Threeuple<string, int, bool> secondThreeple = new Threeuple<string, int, bool>(secondInput[0],int.Parse(secondInput[1]),isDrunk);
            Console.WriteLine(secondThreeple.ToString());
            string[] thirdInput = Console.ReadLine().Split();
            Threeuple<string, double, string> thirdThreeple = new Threeuple<string, double, string>(thirdInput[0],double.Parse(thirdInput[1]),thirdInput[2]);
            Console.WriteLine(thirdThreeple.ToString());
        }
    }
}
