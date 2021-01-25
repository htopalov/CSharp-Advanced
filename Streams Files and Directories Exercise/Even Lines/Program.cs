using System;
using System.IO;
using System.Linq;

namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = Path.Combine("data", "text.txt");
            string destinationPath = Path.Combine("data", "output.txt");
            using (var reader = new StreamReader(sourcePath))
            {
                int count = 0;
                string chars = "-,.!?";
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (count % 2 == 0)
                    {
                        foreach (var item in chars)
                        {
                            line = line.Replace(item, '@');
                        }
                        string[] splittedLine = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
                        Console.WriteLine(string.Join(" ", splittedLine));
                    }
                    count++;
                }
            }
        }
    }
}
