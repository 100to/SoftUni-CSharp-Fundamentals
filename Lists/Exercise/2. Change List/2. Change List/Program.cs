using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] action = command.Split();
                switch (action[0])
                {
                    case "Insert":
                        numbers.Insert(int.Parse(action[2]), int.Parse(action[1]));
                        break;
                    case "Delete":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == int.Parse(action[1]))
                            {
                                numbers.Remove(int.Parse(action[1]));
                                i--;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
