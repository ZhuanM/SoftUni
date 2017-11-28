using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = int.Parse(Console.ReadLine());

            int subtract = 1;
            string input = Console.ReadLine();
            while (input != "Supernova")
            {
                string[] commands = input.Split();
                string direction = commands[0];
                int steps = int.Parse(commands[1]);

                switch (direction)
                {
                    case "left":
                        while (steps-- > 0)
                        {
                            // v sluchai che izlezne ot ramkata na masiva => vrushta go na drugiq krai na masiva
                            if (startIndex == 0)
                            {
                                startIndex = numbers.Length - 1;
                                subtract++;
                                numbers[startIndex] -= subtract;
                                continue;
                            }


                            startIndex--;
                            numbers[startIndex] -= subtract;
                        }
                        break;

                    case "right":
                        while (steps-- > 0)
                        {
                            // v sluchai che izlezne ot ramkata na masiva => vrushta go na drugiq krai na masiva
                            if (startIndex == numbers.Length - 1)
                            {
                                startIndex = 0;
                                subtract++;
                                numbers[startIndex] -= subtract;
                                continue;
                            }


                            startIndex++;
                            numbers[startIndex] -= subtract;
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}