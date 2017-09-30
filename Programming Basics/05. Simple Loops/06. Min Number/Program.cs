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
            int Min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                Min = Math.Min(Min, a);
            }
            Console.WriteLine(Min);
        }
    }
}