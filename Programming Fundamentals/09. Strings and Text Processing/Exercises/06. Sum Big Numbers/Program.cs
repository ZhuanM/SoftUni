using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length > second.Length)
                second = second.PadLeft(first.Length, '0');
            else
                first = first.PadLeft(second.Length, '0');

            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var number = 0;
            var remainder = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = first[i] - 48 + second[i] - 48 + remainder;
                number = sum % 10;
                sb.Append(number);

                if (i == 0 && remainder > 0)
                {
                    sb.Append(remainder);
                }
                remainder = sum / 10;
            }

            Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}