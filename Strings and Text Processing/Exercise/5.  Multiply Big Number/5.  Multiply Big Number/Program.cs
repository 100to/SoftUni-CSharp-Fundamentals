using System;
using System.Collections.Generic;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine().TrimStart(new char[] { '0' });
            int multiply = int.Parse(Console.ReadLine());
            if (multiply == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int decimalReminder = 0;
            int currentMultiply = 0;
            var result = new List<int>();
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int currentDigit = bigNum[i] - '0';
                currentMultiply = currentDigit * multiply;
                currentMultiply += decimalReminder;
                result.Add(currentMultiply % 10);
                decimalReminder = currentMultiply / 10;
            }
            if (decimalReminder > 0)
            {
                result.Add(decimalReminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
