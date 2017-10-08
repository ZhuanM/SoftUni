using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static bool PrimeOrNot(ulong num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                for (ulong i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());

            Console.WriteLine(PrimeOrNot(number));
        }
    }
}