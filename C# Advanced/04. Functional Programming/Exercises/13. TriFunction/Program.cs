using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in names)
            {
                long sum = GetSumOfLetters(name);
                if (sum >= n)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }

        private static long GetSumOfLetters(string name)
        {
            int sum = 0;
            foreach (var letter in name)
            {
                sum += (int)letter;
            }
            return sum;
        }
    }
}