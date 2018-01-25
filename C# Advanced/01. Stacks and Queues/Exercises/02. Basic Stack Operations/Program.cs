using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int pushCount = commands[0];
            int popCount = commands[1];
            int findThisNum = commands[2];

            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers.Take(pushCount));

            for (int i = 0; i < popCount; i++) //This is only in case they don't give us more popCount than the count of elements in the stack
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Contains(findThisNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minStackValue = int.MaxValue;

                while (stack.Count > 0)
                {
                    int currNum = stack.Pop();

                    if (minStackValue > currNum)
                    {
                        minStackValue = currNum;
                    }
                }

                Console.WriteLine(minStackValue);
            }
        }
    }
}