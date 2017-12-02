using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Match_Hex_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[A-F0-9]+\b";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write($"{m.Value} ");
            }
        }
    }
}