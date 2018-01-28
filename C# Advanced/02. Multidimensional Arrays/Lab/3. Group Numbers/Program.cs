using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                sizes[Math.Abs(number % 3)]++; // It's Math Abs because in case we are given negative int as input
                // Gets the count of each group (0, 1, 2) which are the remainder of the number when divided by 3 so we can know the size of the jagged arrays
            }

            int[][] jaggedArray = new int[3][];
            for (int i = 0; i < sizes.Length; i++)
            {
                jaggedArray[i] = new int[sizes[i]]; // This loop is so we can initialize all arrays so we can use them later on
            }

            int[] index = new int[3];
            foreach (var number in numbers)
            {
                int remainder = Math.Abs(number % 3); // It's Math Abs because in case we are given negative int as input
                jaggedArray[remainder][index[remainder]] = number;
                index[remainder]++; // It's so we can move to the next index depending on which row we are at (0, 1, 2)
            }

            // PRINTING
            for (int rows = 0; rows < jaggedArray.Length; rows++)
            {
                for (int columns = 0; columns < jaggedArray[rows].Length; columns++)
                {
                    Console.Write(jaggedArray[rows][columns] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}