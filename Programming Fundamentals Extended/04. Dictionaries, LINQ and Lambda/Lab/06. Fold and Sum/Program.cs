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
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int k = list.Count / 4;

            List<int> leftRow = list.Take(k).Reverse().ToList();
            List<int> rightRow = list.Skip(3 * k).Reverse().ToList();
            List<int> midRow = list.Skip(k).Take(2 * k).ToList();

            List<int> leftAndRightRow = leftRow.Concat(rightRow).ToList();

            //PO NQKAKVA PRICHINA NE RABOTI SUS LIST I DAVA OUT OF INDEX EXCEPTION: List<int> result = new List<int>();
            int[] result = new int[leftAndRightRow.Count];
            for (int i = 0; i < leftAndRightRow.Count; i++)
            {
                result[i] = leftAndRightRow[i] + midRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}