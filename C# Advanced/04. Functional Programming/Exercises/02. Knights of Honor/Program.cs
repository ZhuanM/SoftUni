using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = x => Console.WriteLine(string.Join("\n", x.Select(name => $"Sir {name}")));

            print(names);
        }
    }
}