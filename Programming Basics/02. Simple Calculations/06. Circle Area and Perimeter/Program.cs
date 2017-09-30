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
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI * r * r);
            Console.WriteLine(2 * Math.PI * r);
        }
    }
}