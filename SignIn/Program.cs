using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn
{
    class Program
    {
        static void Main(string[] args)
        {
            int usernameFail = 0;
            int passwordFail = 0;
            for (int i = 0; i <= usernameFail; i++)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();
                if (username != "MurphyDownpour")
                {
                    Console.WriteLine("Try again.");
                    usernameFail++;
                }
                if (usernameFail == 3)
                {
                    Console.WriteLine("Out of limit.");
                    break;
                }
                if (username == "MurphyDownpour")
                {
                    for (int j = 0; j <= passwordFail; j++)
                    {
                        Console.Write("Password: ");
                        string password = Console.ReadLine();
                        if (password != "123")
                        {
                            Console.WriteLine("Try again.");
                            passwordFail++;
                        }
                        if (passwordFail == 3)
                        {
                            Console.WriteLine("Out of limit.");
                            break;
                        }
                        else if (password == "123")
                        {
                            Console.WriteLine("Successful!");
                        }
                    }
                }
            }
            
            
        }
    }
}
