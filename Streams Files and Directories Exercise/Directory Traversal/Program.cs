using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = "./";
            string[] files = Directory.GetFiles(directory);
            Dictionary<string, Dictionary<string, double>> fileInfoCollection = new Dictionary<string, Dictionary<string, double>>();
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfoCollection.ContainsKey(fileInfo.Extension))
                {

                    fileInfoCollection[fileInfo.Extension].Add(fileInfo.Name, fileInfo.Length);
                }
                else
                {
                    Dictionary<string, double> fileNameSize = new Dictionary<string, double>();
                    fileNameSize.Add(fileInfo.Name, fileInfo.Length);
                    fileInfoCollection.Add(fileInfo.Extension, fileNameSize);
                }
            }

            StreamWriter writer = new StreamWriter("report.txt");
            using (writer)
            {
                foreach (KeyValuePair<string, Dictionary<string, double>> keyvalue in fileInfoCollection.OrderByDescending(k => k.Value.Count).ThenBy(name => name.Key))
                {
                    writer.WriteLine(keyvalue.Key);
                    foreach (KeyValuePair<string, double> kv in keyvalue.Value.OrderBy(size => size.Value))
                    {
                        writer.WriteLine("--" + kv.Key + " - {0:F3}kb", kv.Value / 1024);
                    }
                }
            }
        }
    }
}
