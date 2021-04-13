using System;
using System.Collections.Generic;
using System.Linq;

namespace Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] roses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> liliesStack = new Stack<int>(lilies);
            Queue<int> rosesQueue = new Queue<int>(roses);
            int count = 0;
            int sum = 0;
            while (liliesStack.Count > 0 && rosesQueue.Count > 0)
            {
                int lilie = liliesStack.Peek();
                int rose = rosesQueue.Peek();
                if (lilie+ rose == 15)
                {
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                    count++;
                }
                else if (lilie + rose > 15)
                {
                    while (lilie + rose > 15)
                    {
                        if (lilie >= 2)
                        {
                            lilie -= 2;
                        }
                        else if (lilie <= 0)
                        {
                            break;
                        }
                        if (lilie + rose == 15)
                        {
                            liliesStack.Pop();
                            rosesQueue.Dequeue();
                            count++;
                        }
                        else if (lilie + rose < 15)
                        {
                            sum += lilie + rose;
                            liliesStack.Pop();
                            rosesQueue.Dequeue();
                        }
                        else if(lilie + rose > 15)
                        {
                            continue;
                        }
                    }

                }
                else if (lilie + rose < 15)
                {
                    sum += lilie + rose;
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                }
            }

            count += sum / 15;

            if (count >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {count} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - count} wreaths more!");
            }


        }
    }
}
