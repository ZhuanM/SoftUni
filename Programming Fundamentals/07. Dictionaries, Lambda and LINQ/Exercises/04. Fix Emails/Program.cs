using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while(true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                emails[name] = email;
            }

            foreach (var emailAndName in emails)
            {
                if (!emailAndName.Value.EndsWith("us") && !emailAndName.Value.EndsWith("uk"))
                {
                    Console.WriteLine($"{emailAndName.Key} -> {emailAndName.Value}");
                }
            }
        }
    }
}