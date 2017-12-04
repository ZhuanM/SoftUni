using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_3_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}