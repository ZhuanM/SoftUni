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
            var ocenka = double.Parse(Console.ReadLine());
            if (ocenka >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}