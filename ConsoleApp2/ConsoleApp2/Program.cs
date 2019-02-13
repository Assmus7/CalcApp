using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string path = "/Users/markjprice/Code/Chapter03"; // macOS
            string path = @"C:\Code\Chapter03"; // Windows
            Stream s = File.Open(
            Path.Combine(path, "file.txt"),
            FileMode.OpenOrCreate);
            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    WriteLine("The stream is to a file that I can write to.");
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file.");
                    break;
                case MemoryStream ms:
                    WriteLine("The stream is to a memory address.");
                    break;
                default: // всегда оценивается последним,
                         // несмотря на его текущее положение
                    WriteLine("The stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;
            }
        }
    }
}
