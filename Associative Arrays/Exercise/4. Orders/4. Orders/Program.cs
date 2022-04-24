using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productList = new Dictionary<string, List<decimal>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string key = input[0];
                if (key == "buy")
                {
                    break;
                }
                decimal price = decimal.Parse(input[1]);
                decimal quantity = decimal.Parse(input[2]);
                if (!productList.ContainsKey(key))
                {
                    productList.Add(key, new List<decimal>() { price, quantity });
                }
                else
                {
                    productList[key][0] = price;
                    productList[key][1] += quantity;
                }
            }
            foreach (var item in productList)
            {
                decimal sum = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {sum:f2}");
            }
        }
    }
}
