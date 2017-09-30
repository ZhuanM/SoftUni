using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            if (text == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (text == "businessman" || text == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (text == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}