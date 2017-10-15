using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> squareNums = new List<int>();

            foreach (var number in nums)
            {
                if (Math.Sqrt(number) == (int) Math.Sqrt(number))
                {
                    squareNums.Add(number);
                }
            }

            squareNums.Sort();
            squareNums.Reverse();

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}