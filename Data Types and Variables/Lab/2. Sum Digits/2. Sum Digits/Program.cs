using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += int.Parse(a[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
