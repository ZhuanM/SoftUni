using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];

            int[] bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < bugIndexes.Length; j++)
                {
                    if (i == bugIndexes[j])
                    {
                        field[i] = 1;
                    }
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split().ToArray();
                int index = int.Parse(commandArgs[0]);
                string direction = commandArgs[1];
                int flightSpan = int.Parse(commandArgs[2]);

                if (index < 0 || index > field.Length - 1 || field[index] == 0 || flightSpan == 0)
                {
                    continue;
                }

                field[index] = 0;

                if (direction == "right")
                {
                    flyRight(field, index, flightSpan);
                }
                else if (direction == "left")
                {
                    flyLeft(index, flightSpan, field);
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }

        private static void flyLeft(int index, int flightSpan, int[] field)
        {
            for (int i = 1; i < index + 1; i++)
            {
                var flightDistance = (long)i * flightSpan;
                if (index - flightDistance < 0)
                {
                    break;
                }
                if (field[index - flightDistance] == 0)
                {
                    field[index - flightDistance] = 1;
                    break;
                }
            }
        }

        private static void flyRight(int[] field, int index, int flightSpan)
        {
            for (int i = 1; i < field.Length - index; i++)
            {
                var flightDistance = (long)i * flightSpan;
                if (index + flightDistance > field.Length - 1)
                {
                    break;
                }
                if (field[index + flightDistance] == 0)
                {
                    field[index + flightDistance] = 1;
                    break;
                }
            }
        }
    }
}