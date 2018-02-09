﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, double>> extensions = new SortedDictionary<string, Dictionary<string, double>>();
            DirectoryInfo directorySelected = new DirectoryInfo(directory);
            FileInfo[] whole = directorySelected.GetFiles();

            GetFileExtensions(extensions, whole);

            GroupAndWrite(extensions);

        }
        static void GroupAndWrite(SortedDictionary<string, Dictionary<string, double>> extensions)
        {
            var orderedExtension = extensions.OrderByDescending(p => p.Value.Count).ThenBy(ext => ext.Key);
            string myDesktopPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            string fileName = System.IO.Path.Combine(myDesktopPath, "report.txt");

            using (StreamWriter destination = new StreamWriter(fileName))
            {
                foreach (var item in orderedExtension)
                {
                    destination.WriteLine(item.Key);
                    var orderedDic = item.Value.OrderBy(f => f.Value);
                    foreach (var output in orderedDic)
                    {
                        destination.WriteLine("{0}{1}kb", output.Key, output.Value / 1024);
                    }
                }
            }
        }
        static void GetFileExtensions(SortedDictionary<string, Dictionary<string, double>> extensions, FileInfo[] files)
        {
            foreach (var n in files)
            {
                if (!extensions.ContainsKey(n.Extension))
                {
                    extensions.Add(n.Extension, new Dictionary<string, double>
                                    {{string.Format("--{0} - ", n.Name), n.Length}});
                }
                else
                {
                    extensions[n.Extension].Add(string.Format("--{0} - ", n.Name), n.Length);
                }
            }
        }
    }
}