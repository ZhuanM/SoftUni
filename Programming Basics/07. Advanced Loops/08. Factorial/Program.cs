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
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int tmp = n;

            for (int i = 0; i < n; i++)
            {
                a *= tmp;
                tmp--;
            }
            Console.WriteLine(a);
        }
    }
}