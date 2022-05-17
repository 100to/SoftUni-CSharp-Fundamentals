using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"\b(?<day>[0-9]{2})(?<separator>[\/|\.\-])(?<month>[A-Z][a-z]{2})(\k<separator>)(?<year>[0-9]{4})\b");
            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups["day"].Value} Month: {item.Groups["month"].Value} Year: {item.Groups["year"].Value}");
            }
        }
    }
}
