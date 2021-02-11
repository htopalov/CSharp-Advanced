using System;
using System.Collections.Generic;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            ListyIterator<string> listy;
            List<string> listInput = new List<string>();
            if (input.Length > 1)
            {
                for (int i = 1; i < input.Length; i++)
                {
                    listInput.Add(input[i]);
                }
                listy = new ListyIterator<string>(listInput);
            }
            else
            {
                listy = new ListyIterator<string>();
            }
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;

                    case "Print":
                        listy.Print();
                        break;

                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "PrintAll":
                        foreach (var item in listy)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
