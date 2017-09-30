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
            var s = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(s * h / 2, 2));
        }
    }
}