using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool wrong = false, changed = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end" || wrong)
                {
                    break;
                }
                string[] comm = command.Split();
                switch (comm[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(comm[1]));
                        changed = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(comm[2]), int.Parse(comm[1]));
                        changed = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(comm[1]));
                        changed = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(comm[1]));
                        changed = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(comm[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                if (i + 1 == numbers.Count)
                                {
                                    Console.Write($"{numbers[i]}");
                                }
                                else
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                if (i + 1 == numbers.Count)
                                {
                                    Console.Write($"{numbers[i]}");
                                }
                                else
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        if (comm[1] == "<")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (int.Parse(comm[2]) > numbers[i])
                                {
                                    if (i + 1 == numbers.Count)
                                    {
                                        Console.Write($"{numbers[i]}");
                                    }
                                    else
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }
                            }
                        }
                        else if (comm[1] == ">")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (int.Parse(comm[2]) < numbers[i])
                                {
                                    if (i + 1 == numbers.Count)
                                    {
                                        Console.Write($"{numbers[i]}");
                                    }
                                    else
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }
                            }
                        }
                        else if (comm[1] == "<=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (int.Parse(comm[2]) >= numbers[i])
                                {
                                    if (i + 1 == numbers.Count)
                                    {
                                        Console.Write($"{numbers[i]}");
                                    }
                                    else
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }
                            }
                        }
                        else if (comm[1] == ">=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (int.Parse(comm[2]) <= numbers[i])
                                {
                                    if (i + 1 == numbers.Count)
                                    {
                                        Console.Write($"{numbers[i]}");
                                    }
                                    else
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        break;
                    default:
                        wrong = true;
                        break;
                }
            }
            if (changed)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
