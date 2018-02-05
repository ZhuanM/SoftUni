using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine().Trim().ToLower();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(n => ++n).ToList(); break;

                    case "subtract":
                        numbers = numbers.Select(n => --n).ToList(); break;

                    case "multiply":
                        numbers = numbers.Select(n => n * 2).ToList(); break;

                    case "print":
                        Console.WriteLine(string.Join(" ", numbers)); break;
                }

                command = Console.ReadLine().Trim().ToLower();
            }
        }
    }
}