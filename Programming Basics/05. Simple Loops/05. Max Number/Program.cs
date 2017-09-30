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
            int Max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                Max = Math.Max(Max, a);
            }
            Console.WriteLine(Max);
        }
    }
}