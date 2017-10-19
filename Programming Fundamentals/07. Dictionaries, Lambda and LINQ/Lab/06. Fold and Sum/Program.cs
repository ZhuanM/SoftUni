using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var k = nums.Count * 1/4;

            var firstQuarterReversed = nums.Take(k).Reverse().ToList();
            var lastQuarterReversed = nums.Skip(3 * k).Take(k).Reverse().ToList();
            var halfPart = nums.Skip(k).Take(2 * k).ToList();

            var firstAndLastQuarterReversed = firstQuarterReversed.Concat(lastQuarterReversed).ToList();

            var sum = firstAndLastQuarterReversed.Select((x, index) => x + halfPart[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}