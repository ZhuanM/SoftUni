using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<long> fibonacci = new Stack<long>(new long[] { 1, 1 });
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                long frontFibonacci = fibonacci.Pop();
                long lastFibonacci = fibonacci.Pop();
                fibonacci.Push(frontFibonacci);
                fibonacci.Push(lastFibonacci + frontFibonacci);
            }

            //Printing
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(fibonacci.Peek());
            }
        }
    }
}