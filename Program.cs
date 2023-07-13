using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conappAssig5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Username = "Janu";
            string Password = "28665";
            int attemptsRemaining = 3;

            while (attemptsRemaining > 0)
            {
                Console.Write("Enter username: ");
                string enterusername = Console.ReadLine();

                Console.Write("Enter password: ");
                string enterpassword = Console.ReadLine();

                if (enterusername == Username && enterpassword == Password)
                {
                    Console.WriteLine("Login successful.");
                    return;
                }
                else if (enterusername == Username)
                {
                    Console.WriteLine("Invalid password.");
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }

                attemptsRemaining--;
            }

            Console.WriteLine("Login failed.");
        }
    }
}
