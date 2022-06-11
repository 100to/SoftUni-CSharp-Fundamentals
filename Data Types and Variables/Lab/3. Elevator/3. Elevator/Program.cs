using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capasity = int.Parse(Console.ReadLine());
            int sum = 0;
            sum = (int)Math.Ceiling((double)persons / capasity);
            Console.WriteLine(sum);
        }
    }
}
