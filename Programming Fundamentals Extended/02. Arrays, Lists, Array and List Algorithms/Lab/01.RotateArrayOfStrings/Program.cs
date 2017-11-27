using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string lastElementOfInput = input[input.Count - 1];

            input.Remove(lastElementOfInput);
            input.Insert(0, lastElementOfInput);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}