using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skipElements = firstInput[0];
            int takeElements = firstInput[1];

            string input = Console.ReadLine();

            Regex cameraGroups = 
                new Regex(@"\|<(\w{" + skipElements + @"})(\w{0," + takeElements + @"})");

            MatchCollection solution = cameraGroups.Matches(input);

            List<string> picsTaken = new List<string>();

            foreach (Match camera in solution)
            {
                picsTaken.Add(camera.Groups[2].Value.ToString());
            }

            Console.WriteLine(string.Join(", ", picsTaken));
        }
    }
}