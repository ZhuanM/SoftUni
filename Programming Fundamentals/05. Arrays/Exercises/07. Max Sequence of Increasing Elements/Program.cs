using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currSeq = 1;
            int longestSeq = 0;
            int longestStartIndex = 0;
            int currStartIndex = 0;

            for (int i = 1; i < numArr.Length; i++)
            {
                if (numArr[i] <= numArr[i - 1])
                {
                    currSeq = 1;
                    currStartIndex = i;
                }
                else
                    currSeq++;

                if (currSeq > longestSeq)
                {
                    longestSeq = currSeq;
                    longestStartIndex = currStartIndex;
                }
            }

            int endIndex = longestStartIndex + longestSeq;

            for (int i = longestStartIndex; i < endIndex; i++)
            {
                Console.Write(numArr[i] + " ");
            }
        }
    }
}