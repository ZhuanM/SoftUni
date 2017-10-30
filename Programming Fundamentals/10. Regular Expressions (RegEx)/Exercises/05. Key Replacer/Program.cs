using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyInput = Console.ReadLine();

            var startKey = @"[A-Za-z]+[<|||\\]";
            var endKey = @"[<|||\\][A-Z-a-z]+$";

            var startKeyReg = Regex.Match(keyInput, startKey);
            var endKeyReg = Regex.Match(keyInput, endKey);

            var startK = startKeyReg.Value.TrimEnd('<', '|', '\\');
            var endK = endKeyReg.Value.TrimStart('<', '|', '\\');

            var pattern = $"{startK}(.*?){endK}";

            var textInput = Console.ReadLine();

            MatchCollection matches = Regex.Matches(textInput, pattern);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match.Groups[1].Value);               
            }

            if (sb.Length > 0)
                Console.WriteLine(sb.ToString());
            else
                Console.WriteLine("Empty result");
        }
    }
}