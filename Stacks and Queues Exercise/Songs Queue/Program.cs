using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> playlist = new Queue<string>(input);
            while (playlist.Count > 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    playlist.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string song = command.Substring(4);
                    if (playlist.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        playlist.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }
            }
            Console.WriteLine("No more songs!");
        }

    }
}
