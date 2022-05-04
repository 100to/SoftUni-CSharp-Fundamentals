using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
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
                string[] comm = command.Split();
                switch (comm[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(comm[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(comm[2]), int.Parse(comm[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(comm[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(comm[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
