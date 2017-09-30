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
            var C = double.Parse(Console.ReadLine());
            Console.WriteLine((C * 9 / 5) + 32);
        }
    }
}