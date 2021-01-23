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
            Dictionary<string, int> wordCollection = new Dictionary<string, int>();
            string[] words = File.ReadAllText("words.txt").Split();

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    string[] wordsInCurrentLine = currentLine.ToLower()
                    .Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        foreach (var item in wordsInCurrentLine)
                        {
                            if (word == item)
                            {
                                if (!wordCollection.ContainsKey(item))
                                {
                                    wordCollection.Add(item, 1);
                                }
                                else
                                {
                                    wordCollection[item]++;
                                }
                            }
                        }
                    }
                    currentLine = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var item in wordCollection.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
