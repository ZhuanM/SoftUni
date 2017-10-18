using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            nums.Sort();

            var newNums = nums.Skip(nums.Count - 3);

            newNums = newNums.OrderByDescending(x => x);

            Console.WriteLine(string.Join(" ", newNums));
        }
    }
}