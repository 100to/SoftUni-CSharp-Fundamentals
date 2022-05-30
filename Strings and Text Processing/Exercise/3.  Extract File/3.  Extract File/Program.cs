using System;
using System.Linq;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine().Split(@"\").ToArray();
            int index = file[file.Length - 1].IndexOf(".");
            string filename = file[file.Length - 1].Substring(0, index);
            string extension = file[file.Length - 1].Substring(index + 1);
            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
