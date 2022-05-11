using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {
                    for (int j = 0; j < (bomb[1]) + 1; j++)
                    {
                        if (numbers.Count == 0)
                        {
                            break;
                        }
                        if (numbers[0] == bomb[0])
                        {
                            numbers.RemoveAt(0);
                            break;
                        }
                        if (bomb[1] > i)
                        {
                            numbers.RemoveAt(0);
                        }
                        else
                        {
                            numbers.RemoveAt(i - bomb[1]);
                        }
                    }
                    for (int j = 0; j < bomb[1]; j++)
                    {
                        if (numbers.Count == 0 || i - bomb[1] >= numbers.Count)
                        {
                            break;
                        }
                        if (bomb[1] > i)
                        {
                            numbers.RemoveAt(0);
                        }
                        else
                        {
                            numbers.RemoveAt(i - bomb[1]);
                        }
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
