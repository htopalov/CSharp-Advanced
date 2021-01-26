using System;
using System.IO;
using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string toZip = @"..\..\..\copyMe.png";
            string zipped = @"..\..\..\..\NewArchive_copyMe.zip";

            using (var archive = ZipFile.Open(zipped, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(toZip, Path.GetFileName(toZip));
            }
        }
    }
}
