using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int index = text.IndexOf(pattern);

            int count = 0;

            while (index != -1)
            {
                count++;
                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}