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
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");
                Console.WriteLine(String.Concat(Enumerable.Repeat(" *", i - 1)));
            }

            //sredna 4ast
            Console.WriteLine(String.Concat(Enumerable.Repeat("* ", n)));

            //dolna 4ast
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write(String.Concat(Enumerable.Repeat("* ", n - i)));
                Console.WriteLine();
            }
        }
    }
}