using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            var info = new Dictionary<string, int>();
            foreach (var name in names)
            {
                if (!info.ContainsKey(name))
                {
                    info.Add(name, 0);
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }
                MatchCollection matchInfo = Regex.Matches(input, @"(?<distance>\d)|(?<name>[A-Za-z]+)");
                string name = "";
                int distance = 0;
                foreach (Match item in matchInfo)
                {
                    foreach (var item2 in item.Groups["distance"].Value)
                    {
                        distance += int.Parse(item.Groups["distance"].Value);
                    }
                    foreach (var item2 in item.Groups["name"].Value)
                    {
                        name += item2;
                    }
                }
                if (info.ContainsKey(name))
                {
                    info[name] += distance;
                }
            }
            var sortedInfo = info.OrderByDescending(o => o.Value);
            int i = 1;
            foreach (var item in sortedInfo)
            {
                if (i == 1)
                {
                    Console.WriteLine($"{i}st place: {item.Key}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{i}nd place: {item.Key}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"{i}rd place: {item.Key}");
                }
                else
                {
                    break;
                }
                i++;
            }
        }
    }
}
