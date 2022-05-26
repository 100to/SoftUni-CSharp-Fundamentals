using System;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] separatedInput = input.ToCharArray();
            for (int i = 0; i < separatedInput.Length; i++)
            {
                if (char.IsDigit(separatedInput[i]))
                {
                    Console.Write(separatedInput[i].ToString());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < separatedInput.Length; i++)
            {
                if (char.IsLetter(separatedInput[i]))
                {
                    Console.Write(separatedInput[i].ToString());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < separatedInput.Length; i++)
            {
                if (char.IsPunctuation(separatedInput[i]) || char.IsSymbol(separatedInput[i]))
                {
                    Console.Write(separatedInput[i].ToString());
                }
            }
        }
    }
}
