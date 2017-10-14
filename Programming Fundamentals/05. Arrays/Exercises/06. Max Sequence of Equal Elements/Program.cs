using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
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
            int longestSeq = 1;
            int seqNum = numArr[0];

            for (int i = 1; i < numArr.Length; i++)
            {
                if (numArr[i] != numArr[i - 1])
                    currSeq = 1;
                else
                    currSeq++;

                if (currSeq > longestSeq)
                {
                    longestSeq = currSeq;
                    seqNum = numArr[i];
                }
            }

            Console.WriteLine(String.Concat(Enumerable.Repeat(seqNum + " ", longestSeq)));
        }
    }
}