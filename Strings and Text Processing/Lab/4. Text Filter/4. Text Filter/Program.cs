using System;
using System.Linq;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            string sentence = Console.ReadLine();
            foreach (var item in bannedWords)
            {
                sentence = sentence.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(sentence);
        }
    }
}
