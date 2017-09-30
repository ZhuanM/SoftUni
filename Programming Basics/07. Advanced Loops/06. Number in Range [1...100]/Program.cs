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
            Console.Write("Enter a number in the range [1...100]: ");
            int n = int.Parse(Console.ReadLine());

            while (!(1 <= n && n <= 100))
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {n}");
        }
    }
}