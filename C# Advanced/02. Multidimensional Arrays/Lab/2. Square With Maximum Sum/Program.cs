using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowsLength = rowsAndColumns[0];
            int columnsLength = rowsAndColumns[1];

            int[,] matrix = new int[rowsLength, columnsLength];

            for (int rows = 0; rows < rowsLength; rows++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int columns = 0; columns < columnsLength; columns++)
                {
                    matrix[rows, columns] = rowValues[columns];
                }
            }

            int sum = 0;
            // Row and column indexes are here so we can know the location of the sqare with most sum so we can print it out later
            int rowIndex = 0;
            int columnIndex = 0;
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++) // It's rows - 1 because we would jump out of the boundaries of the array
            {
                for (int columns = 0; columns < matrix.GetLength(1) - 1; columns++) // It's columns - 1 because we would jump out of the boundaries of the array
                {
                    int tempSum = matrix[rows, columns] + matrix[rows, columns + 1] // Top 2 numbers of current square
                                   + matrix[rows + 1, columns] + matrix[rows + 1, columns + 1]; // Bottom 2 numbers of current square

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        rowIndex = rows;
                        columnIndex = columns;
                    }
                }
            }

            Console.WriteLine(matrix[rowIndex, columnIndex] + " " + matrix[rowIndex, columnIndex + 1]); // Top 2 numbers of square
            Console.WriteLine(matrix[rowIndex + 1, columnIndex] + " " + matrix[rowIndex + 1, columnIndex + 1]); // Bottom 2 numbers of square
            Console.WriteLine(sum);
        }
    }
}