using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthLimit = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, bool> filter = n => n.Length <= lengthLimit;

            List<string> filteredNames = names.Where(filter).ToList();

            Console.WriteLine(string.Join("\n", filteredNames));
        }
    }
}