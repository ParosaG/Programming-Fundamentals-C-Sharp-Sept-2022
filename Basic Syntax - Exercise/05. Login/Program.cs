using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user = Console.ReadLine();
            string pass = Console.ReadLine();
            for (int i = 0; i <= 3; i++)
            {
                if (i == 3)
                {
                    if (user == ReverseString(pass))
                    {
                        Console.WriteLine("User {0} logged in.", user);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User {0} blocked!", user);
                    }
                }
                else if (pass == ReverseString(user))
                {
                    Console.WriteLine("User {0} logged in.", user);
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    pass = Console.ReadLine();
                }
            }
        }

        private static string ReverseString(string pass)
        {
            throw new NotImplementedException();
        }
    }
}
