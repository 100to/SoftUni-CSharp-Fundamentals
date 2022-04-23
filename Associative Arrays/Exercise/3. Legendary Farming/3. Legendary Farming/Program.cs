using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var minerCollection = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();
            minerCollection.Add("shards", 0);
            minerCollection.Add("motes", 0);
            minerCollection.Add("fragments", 0);
            bool obtained = false;
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string resource = input[i + 1].ToLower();
                    if (minerCollection.ContainsKey(resource))
                    {
                        minerCollection[resource] += quantity;
                    }
                    else if (junk.ContainsKey(resource))
                    {
                        junk[resource] += quantity;
                    }
                    else
                    {
                        junk.Add(resource, quantity);
                    }
                    if (minerCollection["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        minerCollection["shards"] -= 250;
                        obtained = true;
                        break;
                    }
                    else if (minerCollection["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        minerCollection["fragments"] -= 250;
                        obtained = true;
                        break;
                    }
                    else if (minerCollection["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        minerCollection["motes"] -= 250;
                        obtained = true;
                        break;
                    }
                }
                if (obtained)
                {
                    break;
                }
            }
            foreach (var item in minerCollection)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
