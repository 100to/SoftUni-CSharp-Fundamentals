using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<string> orderedProducts = new List<string>();
            double sum = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                MatchCollection matches = Regex.Matches(input, @"(?<item>[A-Z]+[a-z]*)<<(?<price>[0-9]+\.*[0-9]*)!(?<quantity>[0-9]+)");
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        orderedProducts.Add(match.Groups["item"].Value);
                        sum += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);
                    }
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in orderedProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
