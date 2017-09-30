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
            int sum = 0;

            while (n > 0)
            {
                int currLastDigit = n % 10;
                n /= 10;
                sum += currLastDigit;
            }
            Console.WriteLine(sum);
        }
    }
}