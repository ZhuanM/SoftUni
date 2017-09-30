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
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            n1 = n1.ToLower();
            n2 = n2.ToLower();
            if (n1 == n2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
