using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        private static int Fibonacci(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int fNext = 0;
            for (int i = 1; i <= n; i++)
            {
                fNext = f1 + f2;
                f1 = f2;
                f2 = fNext;
            }
            return fNext;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Fibonacci(n));
            }
        }
    }
}