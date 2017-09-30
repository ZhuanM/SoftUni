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

            //gorna 4ast
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            //sredna 4ast
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.WriteLine("*");
                }
            }

            //dolna 4ast
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
