using System;
using System.Linq;

namespace _5._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string[] sortedWords = words.Where(n => n.Length % 2 == 0).ToArray();
            foreach (var item in sortedWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
