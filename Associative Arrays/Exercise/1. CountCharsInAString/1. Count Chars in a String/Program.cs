using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var count = new Dictionary<char, int>();
            foreach (string word in words)
            {
                foreach (char item in word)
                {
                    if (!count.ContainsKey(item))
                    {
                        count.Add(item, 1);
                    }
                    else
                    {
                        count[item]++;
                    }
                }
            }
            foreach (var sorted in count)
            {
                Console.WriteLine($"{sorted.Key} -> {sorted.Value}");
            }
        }
    }
}
