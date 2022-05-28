using System;
using System.Linq;

namespace _2.__Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split().ToArray();
            int ans = CharacterMultiplier(usernames[0], usernames[1]);
            Console.WriteLine(ans);
        }
        static int CharacterMultiplier(string str1, string str2)
        {
            char[] intoSymbols1 = str1.ToCharArray();
            char[] intoSymbols2 = str2.ToCharArray();
            int difference = 0, sum = 0;
            if (intoSymbols1.Length > intoSymbols2.Length)
            {
                difference = intoSymbols1.Length - intoSymbols2.Length;
                for (int i = 0; i < intoSymbols1.Length - difference; i++)
                {
                    sum += ((int)intoSymbols1[i] * (int)intoSymbols2[i]);
                }
                for (int i = intoSymbols1.Length - difference; i < intoSymbols1.Length; i++)
                {
                    sum += (int)intoSymbols1[i];
                }
            }
            else if (intoSymbols1.Length < intoSymbols2.Length)
            {
                difference = intoSymbols2.Length - intoSymbols1.Length;
                for (int i = 0; i < intoSymbols2.Length - difference; i++)
                {
                    sum += ((int)intoSymbols1[i] * (int)intoSymbols2[i]);
                }
                for (int i = intoSymbols2.Length - difference; i < intoSymbols2.Length; i++)
                {
                    sum += (int)intoSymbols2[i];
                }
            }
            else
            {
                for (int i = 0; i < intoSymbols2.Length; i++)
                {
                    sum += ((int)intoSymbols1[i] * (int)intoSymbols2[i]);
                }
            }
            return sum;
        }
    }
}

