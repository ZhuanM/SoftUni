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
            var Inches = double.Parse(Console.ReadLine());
            var Centimeters = Inches * 2.54;
            Console.WriteLine(Centimeters);
        }
    }
}