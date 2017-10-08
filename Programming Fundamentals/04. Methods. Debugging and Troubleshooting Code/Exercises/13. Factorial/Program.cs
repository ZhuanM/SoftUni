using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));
        }

        static BigInteger Factorial(int num)
        {
            BigInteger result = BigInteger.One;

            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}