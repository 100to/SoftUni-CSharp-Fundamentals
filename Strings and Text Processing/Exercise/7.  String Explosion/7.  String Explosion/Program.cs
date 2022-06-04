using System;

namespace _7.__String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int index = 0;
            int power = 0;
            while (input.IndexOf(">", index) != -1)
            {
                int tempIndex = input.IndexOf(">", index);
                power += int.Parse(input[tempIndex + 1].ToString());
                while (power != 0)
                {
                    if (input.Length == tempIndex + 1)
                    {
                        break;
                    }
                    if (input[tempIndex + 1].ToString() == ">")
                    {
                        break;
                    }
                    else
                    {
                        input = input.Remove(tempIndex + 1, 1);
                        power--;
                    }
                }
                index = tempIndex + 1;
            }
            Console.WriteLine(input);
        }
    }
}
