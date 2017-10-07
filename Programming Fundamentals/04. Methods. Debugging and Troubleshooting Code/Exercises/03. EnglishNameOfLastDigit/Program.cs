using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfLastDigit
{
    class Program
    {
        static string LastDigitInEnglish(long num)
        {
            string lastDigitInEnglish = String.Empty;
            long lastDigit = num % 10;
            switch (Math.Abs(lastDigit))
            {
                case 0:
                    lastDigitInEnglish = "zero"; break;
                case 1:
                    lastDigitInEnglish = "one"; break;
                case 2:
                    lastDigitInEnglish = "two"; break;
                case 3:
                    lastDigitInEnglish = "three"; break;
                case 4:
                    lastDigitInEnglish = "four"; break;
                case 5:
                    lastDigitInEnglish = "five"; break;
                case 6:
                    lastDigitInEnglish = "six"; break;
                case 7:
                    lastDigitInEnglish = "seven"; break;
                case 8:
                    lastDigitInEnglish = "eight"; break;
                case 9:
                    lastDigitInEnglish = "nine"; break;
                default: break;
            }
            return lastDigitInEnglish;
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitInEnglish(number));
        }
    }
}