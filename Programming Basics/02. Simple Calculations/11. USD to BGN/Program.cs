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
            var usd = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} BGN", usd * 1.79549);
        }
    }
}