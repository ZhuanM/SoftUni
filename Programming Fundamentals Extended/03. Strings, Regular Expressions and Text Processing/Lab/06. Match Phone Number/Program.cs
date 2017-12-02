using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(-|\s)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            List<string> result = new List<string>();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                if (m.Success)
                {
                    result.Add(m.Value);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}