using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines(Path.Combine("data", "words.txt"));
            string[] textLines = File.ReadAllLines(Path.Combine("data", "text.txt"));
            Dictionary<string, int> collection = new Dictionary<string, int>();
            foreach (var word in words)
            {
                foreach (var line in textLines)
                {
                    string[] wordsInCurrentLine = line.ToLower().Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < wordsInCurrentLine.Length; i++)
                    {
                        if (word == wordsInCurrentLine[i])
                        {
                            if (!collection.ContainsKey(word))
                            {
                                collection.Add(word, 1);
                            }
                            else
                            {
                                collection[word]++;
                            }
                        }
                    }
                }
            }
            foreach (var item in collection)
            {
                File.AppendAllText(Path.Combine("data", "actualResult.txt"), $"{item.Key} - {item.Value}"+Environment.NewLine);
            }
            foreach (var item in collection.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(Path.Combine("data", "expectedResult.txt"), $"{item.Key} - {item.Value}"+Environment.NewLine);
            }
        }
    }
}
