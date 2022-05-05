using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capasity = int.Parse(Console.ReadLine());
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] action = command.Split();
                if (action[0] == "Add")
                {
                    wagons.Add(int.Parse(action[1]));
                }
                else
                {
                    int put = int.Parse(action[0]);
                    if (put > capasity || put < 0)
                    {
                        break;
                    }
                    int i = 0;
                    while (true)
                    {
                        if (i > wagons.Count)
                        {
                            break;
                        }
                        if (wagons[i] + put <= capasity)
                        {
                            wagons[i] += put;
                            break;
                        }
                        i++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
