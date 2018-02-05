using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Func<int, bool> filter = x => x % n != 0;

            List<int> resultNums = numbers.Where(filter).ToList();

            Console.WriteLine(string.Join(" ", resultNums));
        }
    }
}