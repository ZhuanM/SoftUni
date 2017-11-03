using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> allFiles = new List<string>();

            for (int i = 0; i < n; i++)
            {
                allFiles.Add(Console.ReadLine());
            }

            string filter = Console.ReadLine();
            var filterTokens = Regex.Split(filter, " in ");
            var filterExt = "." + filterTokens[0];
            var filterRoot = $@"{filterTokens[1]}\";

            Dictionary<string, decimal> filePlusSize = new Dictionary<string, decimal>();

            foreach (var f in allFiles)
            {
                var pathPlusSize = f.Split(';');
                var currentFilePath = pathPlusSize[0];
                decimal currentFileSize = decimal.Parse(pathPlusSize[1]);

                if (currentFilePath.StartsWith(filterRoot) && currentFilePath.EndsWith(filterExt))
                {
                    var tokens = currentFilePath.Split('\\');;
                    var fileName = tokens[tokens.Length - 1];

                    filePlusSize[fileName] = currentFileSize;
                }
            }

            var sortedOutputFiles = filePlusSize.OrderByDescending(fs => fs.Value).ThenBy(fs => fs.Key);

            if (sortedOutputFiles.Count() > 0)
            {
                foreach (var file in sortedOutputFiles)
                {
                    Console.WriteLine(file.Key + " - " + file.Value + " KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}