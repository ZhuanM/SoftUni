using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int addCount = commands[0];
            int removeCount = commands[1];
            int findThisNum = commands[2];

            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(numbers.Take(addCount));

            for (int i = 0; i < removeCount; i++) //This is only in case they don't give us more removeCount than the count of elements in the stack
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (queue.Contains(findThisNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minQueueValue = int.MaxValue;

                while (queue.Count > 0)
                {
                    int currNum = queue.Dequeue();

                    if (minQueueValue > currNum)
                    {
                        minQueueValue = currNum;
                    }
                }

                Console.WriteLine(minQueueValue);
            }
        }
    }
}