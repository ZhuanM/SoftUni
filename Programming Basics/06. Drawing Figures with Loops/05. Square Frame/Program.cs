using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            Console.Write(String.Concat(Enumerable.Repeat("- ", n - 2)));
            Console.WriteLine("+");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");
                Console.Write(String.Concat(Enumerable.Repeat("- ", n - 2)));
                Console.WriteLine("|");
            }

            Console.Write("+ ");
            Console.Write(String.Concat(Enumerable.Repeat("- ", n - 2)));
            Console.WriteLine("+");
        }
    }
}