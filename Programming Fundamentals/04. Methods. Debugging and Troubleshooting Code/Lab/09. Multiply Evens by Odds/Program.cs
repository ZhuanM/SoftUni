using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            int lastDigit = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                if (n % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            int lastDigit = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                if (n % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            int evenSum = GetSumOfEvenDigits(n);
            int oddSum = GetSumOfOddDigits(n);
            return evenSum * oddSum;
        }

        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }
    }
}