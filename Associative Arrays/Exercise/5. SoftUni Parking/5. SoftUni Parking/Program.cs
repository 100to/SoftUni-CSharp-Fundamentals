using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var parkingLot = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                string key = input[1];
                if (command == "register")
                {
                    string license = input[2];
                    if (!parkingLot.ContainsKey(key))
                    {
                        parkingLot.Add(key, license);
                        Console.WriteLine($"{key} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!parkingLot.ContainsKey(key))
                    {
                        Console.WriteLine($"ERROR: user {key} not found");
                    }
                    else
                    {
                        parkingLot.Remove(key);
                        Console.WriteLine($"{key} unregistered successfully");
                    }
                }
            }
            foreach (var item in parkingLot)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
