using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var CompanyUsers = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                string company = input[0];
                string id = input[1];
                if (!CompanyUsers.ContainsKey(company))
                {
                    CompanyUsers.Add(company, new List<string>() { id });
                }
                else if (!CompanyUsers[company].Contains(id))
                {
                    CompanyUsers[company].Add(id);
                }
            }
            foreach (var item in CompanyUsers)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}
