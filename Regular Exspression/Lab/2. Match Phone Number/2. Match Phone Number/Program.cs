using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"(\+359 2 [0-9]{3} [0-9]{4})|(\+359\-2\-[0-9]{3}\-[0-9]{4}\b)");
            foreach (Match item in matches)
            {
                Console.Write($"{item.Value} ");

            }
        }
    }
}
