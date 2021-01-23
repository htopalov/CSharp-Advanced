using System;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                string line = reader.ReadLine();
                int count = 0;
                using (var writer = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        if (count % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
