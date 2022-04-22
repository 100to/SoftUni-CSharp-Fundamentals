using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = string.Empty;
            int quantity = 0;
            var minerCollection = new Dictionary<string, int>();
            while (true)
            {
                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
                if (minerCollection.ContainsKey(resource))
                {
                    minerCollection[resource] += quantity;
                }
                else
                {
                    minerCollection.Add(resource, quantity);
                }
            }
            foreach (var sorted in minerCollection)
            {
                Console.WriteLine($"{sorted.Key} -> {sorted.Value}");
            }
        }
    }
}
