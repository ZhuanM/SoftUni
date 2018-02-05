using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> getMinNum = GetMin;

            int minNumber = getMinNum(numbers);

            Console.WriteLine(minNumber);
        }

        private static int GetMin(int[] nums)
        {
            int minNum = int.MaxValue;

            foreach (var num in nums)
            {
                if (num < minNum)
                {
                    minNum = num;
                }
            }

            return minNum;
        }
    }
}