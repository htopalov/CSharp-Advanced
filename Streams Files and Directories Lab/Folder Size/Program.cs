using System;
using System.IO;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesPaths = Directory.GetFiles("TestFolder");
            double size = 0;
            foreach (var file in filesPaths)
            {
                FileInfo info = new FileInfo(file);
                size += info.Length;
            }
            Console.WriteLine($"Folder size: {size/1024/1024:f2} MB");
        }
    }
}
