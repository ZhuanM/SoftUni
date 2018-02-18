using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

class Program
{
    static void Main(string[] args)
    {
        int rhombusSize = int.Parse(Console.ReadLine());

        for (int rowSize = 0; rowSize <= rhombusSize; rowSize++)
        {
            PrintRow(rhombusSize, rowSize);
        }

        for (int rowSize = rhombusSize - 1; rowSize > 0; rowSize--)
        {
            PrintRow(rhombusSize, rowSize);
        }
    }

    static void PrintRow(int rhombusSize, int rowSize)
    {
        for (int i = 0; i < rhombusSize - rowSize; i++)
        {
            Console.Write(" ");
        }

        for (int i = 0; i < rowSize; i++)
        {
            Console.Write("* ");
        }

        Console.WriteLine();
    }
}