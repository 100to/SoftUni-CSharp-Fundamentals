using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
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
                        if (int.Parse(comm[2]) < 0 || int.Parse(comm[2]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(comm[2]), int.Parse(comm[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(comm[1]) < 0 || int.Parse(comm[1]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(comm[1]));
                        }
                        break;
                    case "Shift":
                        if (comm[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(comm[2]) % numbers.Count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(comm[2]) % numbers.Count; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
