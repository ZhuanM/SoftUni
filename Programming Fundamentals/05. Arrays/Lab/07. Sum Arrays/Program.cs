using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int len1 = arr1.Length;
            int len2 = arr2.Length;

            int[] resultArr = new int[Math.Max(len1, len2)];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = arr1[i % len1] + arr2[i % len2];
            }

            Console.WriteLine(String.Join(" ", resultArr));
        }
    }
}