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
            int integerCount = 0;

            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    integerCount++;
                }

                catch
                {
                    Console.WriteLine(integerCount);
                    break;
                }
            }
        }
    }
}