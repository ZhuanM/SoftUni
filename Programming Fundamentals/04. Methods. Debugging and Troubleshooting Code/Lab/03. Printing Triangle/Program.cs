using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void PrintLine(int n)
        {
            //gorna 4ast
            Console.WriteLine(new string('-', n * 2));
            //sreda
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('-');
                Console.Write(String.Concat(Enumerable.Repeat("\\/", n - 1)));
                Console.WriteLine('-');
            }
            //dolna 4ast
            Console.WriteLine(new string('-', n * 2));
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintLine(n);
        }
    }
}