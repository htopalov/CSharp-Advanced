using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] roses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> liliesStack = new Stack<int>(lilies);
            Queue<int> rosesQueue = new Queue<int>(roses);
            int wreaths = 0;
            int stored = 0;
            while(liliesStack.Count>0 && rosesQueue.Count>0)
            {
                int lili = liliesStack.Pop();
                int rose = rosesQueue.Dequeue();
                if (lili + rose == 15)
                {
                    wreaths++;
                }
                else if(lili+rose >15)
                {
                    while(lili+rose >15)
                    {
                        if (lili>=2)
                        {
                            lili -= 2;
                        }
                        else if (lili <=0)
                        {
                            break;
                        }
                        if (lili + rose < 15)
                        {
                            stored += lili + rose;
                        }
                        else if (lili + rose == 15)
                        {
                            wreaths++;
                        }
                        else if (lili + rose > 15)
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    stored += lili + rose;
                }
            }
            wreaths += stored / 15;
            if (wreaths >=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreaths} wreaths more!");
            }
        }
    }
}
