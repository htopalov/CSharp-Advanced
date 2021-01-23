using System;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstCollection = File.ReadAllLines("FileOne.txt");
            string[] secondCollection = File.ReadAllLines("FileTwo.txt");
            for (int i = 0; i < firstCollection.Length; i++)
            {
                File.AppendAllText("output.txt", firstCollection[i] + Environment.NewLine + secondCollection[i] + Environment.NewLine);
            }
        }
    }
}
