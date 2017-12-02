using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*]\.)*$", RegexOptions.Multiline);
            string input = Console.ReadLine();

            List<string> result = new List<string>();
            while (input != "Traincode!")
            {
                if (pattern.IsMatch(input))
                {
                    result.Add(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", result));
        }
    }
}