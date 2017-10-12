using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[numArr.Length];
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int[] rotated = new int[numArr.Length];
                rotated[0] = numArr[numArr.Length - 1];
                for (int j = 1; j < rotated.Length; j++)
                {
                    rotated[j] = numArr[j - 1];
                }

                for (int g = 0; g < sum.Length; g++)
                {
                    sum[g] += rotated[g];
                }

                numArr = rotated;
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}