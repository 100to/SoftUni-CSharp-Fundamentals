using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double sum = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                MatchCollection matches = Regex.Matches(input, @"\%(?<name>[A-Z][a-z]+)\%<(?<item>[A-Z][a-z]+)>\w*\|(?<quantity>[0-9]+)\|\D*(?<price>[0-9]+\.*[0-9]*)\$");
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        double priceOfTheOrder = double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);
                        Console.WriteLine($"{match.Groups["name"].Value}: {match.Groups["item"].Value} - {priceOfTheOrder:f2}");
                        sum += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);
                    }
                }
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
