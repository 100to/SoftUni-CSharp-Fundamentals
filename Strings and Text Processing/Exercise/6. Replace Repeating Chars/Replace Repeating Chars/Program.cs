using System;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder convertedInput = new StringBuilder(input);
            for (int i = 0; i < convertedInput.Length - 1; i++)
            {
                if (convertedInput[i] == convertedInput[i + 1])
                {
                    convertedInput.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(convertedInput);
        }
    }
}
