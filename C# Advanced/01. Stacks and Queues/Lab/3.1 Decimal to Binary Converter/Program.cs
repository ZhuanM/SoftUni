using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Decimal_to_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            Stack<int> stack = new Stack<int>();

            //pushing the transformed decimal (in binary) into the stack
            while (decimalNumber > 0)
            {
                stack.Push(decimalNumber % 2);

                decimalNumber /= 2;
            }

            //printing the binary code
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}