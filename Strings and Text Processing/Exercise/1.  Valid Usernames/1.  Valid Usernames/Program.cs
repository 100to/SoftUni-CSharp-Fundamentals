using System;
using System.Linq;

namespace _1.__Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ").ToArray();
            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool notValid = false;
                    foreach (var symbol in username)
                    {
                        if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                        {
                            continue;
                        }
                        else
                        {
                            notValid = true;
                            break;
                        }
                    }
                    if (!notValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
