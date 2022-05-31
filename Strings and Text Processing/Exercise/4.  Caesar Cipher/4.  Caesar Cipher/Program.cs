using System;
using System.Text;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] words = input.ToCharArray();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                int unicode = (int)words[i] + 3;
                words[i] = (char)unicode;
                result.Append(words[i]);
            }
            Console.WriteLine(result);
        }
    }
}
