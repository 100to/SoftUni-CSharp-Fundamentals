using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int actions = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < actions; i++)
            {
                string sentence = Console.ReadLine();
                string[] commands = sentence.Split();
                if (commands[2] == "going!")
                {
                    if (guests.Contains(commands[0]))
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(commands[0]);
                    }
                }
                else
                {
                    if (guests.Contains(commands[0]))
                    {
                        guests.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
