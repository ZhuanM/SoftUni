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

            //gorna 4ast (1 red)
            Console.Write(new string(' ', n + 1));
            Console.Write("|");
            Console.WriteLine(new string(' ', n + 1));

            //dolna 4ast (the rest)
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(" ");
                Console.Write("|");
                Console.Write(" ");
                Console.Write(new string('*', i));
                Console.WriteLine();
            }
        }
    }
}
