using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("data", "text.txt");
            string destination = Path.Combine("data", "output.txt");
            string[] lines = File.ReadAllLines(path);
            int charsCount = 0;
            int punctCount = 0;
            int lineCount = 1;
            foreach (var line in lines)
            {
                foreach (var position in line)
                {
                    if (char.IsLetter(position))
                    {
                        charsCount++;
                    }
                    else if (char.IsPunctuation(position))
                    {
                        punctCount++;
                    }
                }
                File.AppendAllText(destination, $"Line {lineCount}: {line} ({charsCount})({punctCount})" + Environment.NewLine);
                lineCount++;
                charsCount = 0;
                punctCount = 0;
            }
        }
    }
}
