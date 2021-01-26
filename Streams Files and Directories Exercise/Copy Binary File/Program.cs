using System;
using System.IO;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamRead = new FileStream("copyMe.png", FileMode.Open))
            {
                using (var streamWrite = new FileStream("newFile.png", FileMode.OpenOrCreate))
                {
                    byte[] buff = new byte[4096];
                    while (streamRead.Position < streamRead.Length)
                    {
                        streamRead.Read(buff, 0, buff.Length);
                        streamWrite.Write(buff, 0, buff.Length);
                    }
                }
            }
        }
    }
}
