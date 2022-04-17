using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string wordInLower = word.ToLower();
                if (count.ContainsKey(wordInLower))
                {
                    count[wordInLower]++;
                }
                else
                {
                    count.Add(wordInLower, 1);
                }
            }
            foreach (var word in count)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
