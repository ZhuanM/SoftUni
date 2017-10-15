using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] operations = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var newCollection = collection.Take(operations[0]).ToList();
            newCollection.RemoveRange(0, operations[1]);

            if (newCollection.Contains(operations[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}