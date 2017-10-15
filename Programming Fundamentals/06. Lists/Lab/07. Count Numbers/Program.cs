using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
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
            List<int> passed = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (!passed.Contains(nums[i]))
                {
                    int count = 0;

                    for (int j = i; j < nums.Count; j++)
                    {
                        if (nums[j] == nums[i])
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"{nums[i]} -> {count}");
                    passed.Add(nums[i]);
                }
            }
        }
    }
}