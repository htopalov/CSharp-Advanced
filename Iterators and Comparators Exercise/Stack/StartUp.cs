using System;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            string[] input = Console.ReadLine().Split(new string[] { ","," " }, StringSplitOptions.RemoveEmptyEntries);
            string command = input[0];
            while (command != "END")
            {
                if (command == "Push")
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        myStack.Push(input[i]);
                    }
                }
                else if (command == "Pop")
                {
                    myStack.Pop();
                }
                input = Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
                command = input[0];
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
