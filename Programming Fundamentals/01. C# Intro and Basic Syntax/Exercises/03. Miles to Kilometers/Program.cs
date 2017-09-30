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
            //1 mile == 1.60934 kilometers
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine($"{n * 1.60934:f2}");
        }
    }
}