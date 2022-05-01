using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bigger = numbers.Count;
            if (bigger < numbers2.Count)
            {
                bigger = numbers2.Count;
            }
            for (int i = 0; i < bigger; i++)
            {
                if (i < numbers.Count)
                {
                    Console.Write($"{numbers[i]} ");
                }
                if (i < numbers2.Count)
                {
                    Console.Write($"{numbers2[i]} ");
                }
            }
        }
    }
}
