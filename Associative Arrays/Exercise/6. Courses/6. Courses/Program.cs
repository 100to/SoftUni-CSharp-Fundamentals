using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var coursePeople = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ").ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                string course = input[0];
                string name = input[1];
                if (!coursePeople.ContainsKey(course))
                {
                    coursePeople.Add(course, new List<string>() { name });
                }
                else
                {
                    coursePeople[course].Add(name);
                }
            }
            foreach (var item in coursePeople)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}
