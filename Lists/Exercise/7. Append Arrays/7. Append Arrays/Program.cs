using System;
using System.Collections.Generic;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] firstSeparation = array.Split("|"); // razdelq na nqkolko masiva s razdelenie |
            List<int> final = new List<int>();
            for (int i = firstSeparation.Length - 1; i >= 0; i--)
            {
                string[] secondSeparation = firstSeparation[i].Split(); // na vsqka chast ot masiva maha po edin space
                for (int j = 0; j < secondSeparation.Length; j++)
                {
                    if (secondSeparation[j] != "")//ako e imalo dvoen space da go premahne i nego
                    {
                        final.Add(int.Parse(secondSeparation[j]));
                    }
                }
            }
            Console.WriteLine(string.Join(" ", final));
        }
    }
}
