using System;
using System.Collections.Generic;

namespace _3._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            bool synonym = false;
            string key = "";
            for (int i = 0; i < n * 2; i++)
            {
                string word = Console.ReadLine();
                if (!words.ContainsKey(word) && !synonym)
                {
                    words.Add(word, new List<string>());
                    synonym = true;
                    key = word;
                }
                else if (words.ContainsKey(word) && !synonym)
                {
                    key = word;
                    synonym = true;
                }
                else if (synonym)
                {
                    words[key].Add(word);
                    synonym = false;
                }
            }
            foreach (var word in words)
            {
                Console.Write($"{word.Key} - {string.Join(", ", word.Value)}");
                Console.WriteLine();
            }
        }
    }
}
