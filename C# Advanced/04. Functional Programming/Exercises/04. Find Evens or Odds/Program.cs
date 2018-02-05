using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int startNum = inputNumbers[0];
            int endNum = inputNumbers[1];

            string evenOrOdd = Console.ReadLine().Trim().ToLower();
            Func<int, bool> format;

            switch (evenOrOdd)
            {
                case "odd":
                    format = x => x % 2 != 0; break;

                case "even":
                    format = x => x % 2 == 0; break;
                
                default:
                    format = null; break;
            }

            Queue<int> result = TargetNums(startNum, endNum, format);

            Console.WriteLine(string.Join(" ", result));
        }

        private static Queue<int> TargetNums(int start, int end, Func<int, bool> filter)
        {
            Queue<int> result = new Queue<int>();

            for (int i = start; i <= end; i++)
            {
                if (filter(i))
                {
                    result.Enqueue(i);
                }
            }

            return result;
        }
    }
}