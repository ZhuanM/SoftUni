using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int diff = int.Parse(Console.ReadLine());

            Array.Sort(numArr);

            int count = 0;

            for (int i = 0; i < numArr.Length - 1; i++)
            {
                for (int j = i + 1; j < numArr.Length; j++)
                {
                    if (Math.Abs(numArr[i] - numArr[j]) == diff)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}