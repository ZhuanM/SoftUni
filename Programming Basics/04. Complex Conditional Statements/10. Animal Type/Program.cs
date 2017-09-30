using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine().ToLower();

            if (n == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (n == "snake" || n == "crocodile" || n == "tortoise")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}