using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int index = nums[0];
            int maxCount = 1;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        index = nums[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            Console.Write(string.Concat(Enumerable.Repeat($"{index} ", maxCount)));
        }
    }
}