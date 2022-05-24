using System;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            while (input.Contains(word))
            {
                int index = input.IndexOf(word);
                input = input.Remove(index, word.Length);
            }
            Console.WriteLine(input);
        }
    }
}
