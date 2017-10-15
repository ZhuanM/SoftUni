using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int sum = 0;

            foreach (string number in nums)
            {
                char[] charArr = number.ToCharArray();
                charArr = charArr.Reverse().ToArray();
                int numberToAdd = int.Parse(new string(charArr));
                sum += numberToAdd;
            }

            Console.WriteLine(sum);
        }
    }
}