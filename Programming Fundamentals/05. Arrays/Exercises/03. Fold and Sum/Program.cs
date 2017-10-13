using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = numArr.Length * 1 / 4;

            int[] firstQuarterArr = numArr.Take(k).ToArray();
            int[] halfArr = numArr.Skip(k).Take(k * 2).ToArray();
            int[] lastQuarterArr = numArr.Skip(k * 3).Take(k).ToArray();

            int[] firstReversed = firstQuarterArr.Reverse().ToArray();
            int[] lastReversed = lastQuarterArr.Reverse().ToArray();

            int[] firstAndLastCombined = firstReversed.Concat(lastReversed).ToArray();

            int[] result = new int[k * 2];

            for (int i = 0; i < k * 2; i++)
            {
                result[i] = firstAndLastCombined[i] + halfArr[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}