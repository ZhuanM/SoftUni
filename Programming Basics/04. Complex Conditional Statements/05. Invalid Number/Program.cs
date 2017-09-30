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
            int n = int.Parse(Console.ReadLine());
            bool a = (n >= 100 && n <= 200) || n == 0;
            if (!a)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}