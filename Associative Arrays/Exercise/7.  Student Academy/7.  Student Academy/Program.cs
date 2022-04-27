using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.__Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentsIGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsIGrades.ContainsKey(name))
                {
                    studentsIGrades.Add(name, new List<double>() { grade });
                }
                else
                {
                    studentsIGrades[name].Add(grade);
                }
            }
            foreach (var item in studentsIGrades)
            {
                if (item.Value.Sum() / item.Value.Count >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {(item.Value.Sum() / item.Value.Count):f2}");
                }
            }
        }
    }
}
