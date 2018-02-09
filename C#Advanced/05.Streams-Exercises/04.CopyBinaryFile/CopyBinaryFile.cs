﻿using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            using (var source = new FileStream(@"C:\SoftwareUniversity\SoftUni-C-FundamentalsModule\C#Advanced\05.Streams-Exercises\Resources\copyMe.png", FileMode.Open))
            {
                using (var destination = new FileStream("copyMe-Copy.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[1024];
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        else
                        {
                            destination.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
    }
}
