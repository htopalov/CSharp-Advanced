using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                string line = reader.ReadLine();
                int counter = 1;
                using (var writer = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
