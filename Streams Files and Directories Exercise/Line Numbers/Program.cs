using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(Path.Combine("data", "text.txt"));
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
                File.AppendAllText(Path.Combine("data", "output.txt"), $"Line {lineCount}: {line} ({charsCount})({punctCount})" + Environment.NewLine);
                lineCount++;
                charsCount = 0;
                punctCount = 0;
            }
        }
    }
}
