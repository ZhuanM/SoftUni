using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            long[][] triangle = new long[height][]; // It's long because if we enter 60 as input it will overflow at the end

            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
                triangle[currentHeight] = new long[currentHeight + 1];

                triangle[currentHeight][0] = 1; // The first row which is static
                triangle[currentHeight][currentHeight] = 1; // The second row which is static

                if (currentHeight >= 2) // From the third row and onwards
                {
                    for (int widthCounter = 1; widthCounter < currentHeight; widthCounter++) // We start from 1 and end on minus 1 because we already have them filled with 1's
                    {
                        // This makes sense if you look at the presentation gif for forming the pascal triangle
                        triangle[currentHeight][widthCounter] =
                            triangle[currentHeight - 1][widthCounter - 1] +
                            triangle[currentHeight - 1][widthCounter];
                    }
                }
            }

            // PRINTING
            for (int rows = 0; rows < triangle.Length; rows++)
            {
                for (int columns = 0; columns < triangle[rows].Length; columns++)
                {
                    Console.Write(triangle[rows][columns] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}