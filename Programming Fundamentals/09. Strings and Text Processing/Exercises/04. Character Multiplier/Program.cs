using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            string wordOne = input[0];
            string wordTwo = input[1];

            int shorterStrLength;
            int longerStrLength;
            string longerString;

            if (wordTwo.Length > wordOne.Length)
            {
                shorterStrLength = wordOne.Length;
                longerStrLength = wordTwo.Length;
                longerString = wordTwo;
            }
            else
            {
                shorterStrLength = wordTwo.Length;
                longerStrLength = wordOne.Length;
                longerString = wordOne;
            }

            int sum = 0;
            for (int i = 0; i < shorterStrLength; i++)
            {
                sum += (int) wordOne[i] * (int) wordTwo[i];
            }

            for (int i = shorterStrLength; i < longerStrLength; i++)
            {
                sum += (int) longerString[i];
            }

            Console.WriteLine(sum);
        }
    }
}