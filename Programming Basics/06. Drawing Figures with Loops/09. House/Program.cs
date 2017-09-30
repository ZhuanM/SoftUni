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

            int evenDashes = (n - 2) / 2;
            int oddDashes = (n - 1) / 2;
            int evenStars = 4;
            int oddStars = 3;

            //gorna 4ast
            if (n % 2 == 0)
            {
                //purvi red
                Console.Write(new string('-', n / 2 - 1));
                Console.Write("**");
                Console.WriteLine(new string('-', n / 2 - 1));

                //ostanala 4ast ot roof-a
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    evenDashes--;
                    Console.Write(new string('-', evenDashes));
                    Console.Write(new string('*', evenStars));
                    Console.WriteLine(new string('-', evenDashes));
                    evenStars += 2;
                }
            }
            else
            {
                //purvi red
                Console.Write(new string('-', n / 2));
                Console.Write("*");
                Console.WriteLine(new string('-', n / 2));

                //ostanala 4ast ot roof-a
                for (int i = 0; i < n / 2; i++)
                {
                    oddDashes--;
                    Console.Write(new string('-', oddDashes));
                    Console.Write(new string('*', oddStars));
                    Console.WriteLine(new string('-', oddDashes));
                    oddStars += 2;
                }
            }

            //dolna 4ast
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}