using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(-|\s)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(input, pattern);

            string[] listOfNums = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", listOfNums));
        }
    }
}