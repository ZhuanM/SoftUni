using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);

            for (int i = 0; i < n; i++)
            {
                int[] commandTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = commandTokens[0];
                switch (command)
                {
                    case 1:
                        int numberToPush = commandTokens[1];
                        stack.Push(numberToPush);

                        if (numberToPush >= maxStack.Peek())
                        {
                            maxStack.Push(numberToPush);
                        }
                        break;

                    case 2:
                        int poppedNumber = stack.Pop();
                        if (poppedNumber == maxStack.Peek())
                        {
                            maxStack.Pop();
                        }
                        break;

                    case 3:
                        int maxNumber = maxStack.Peek();
                        Console.WriteLine(maxNumber);
                        break;
                }
            }
        }
    }
}