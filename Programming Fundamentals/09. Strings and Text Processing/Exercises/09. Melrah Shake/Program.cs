using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            StringBuilder messages = new StringBuilder();

            if (pattern.Length == 0)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(text);
                return;
            }

            while (true)
            {
                var firstOccureence = text.IndexOf(pattern);
                var lastOccureence = text.LastIndexOf(pattern);

                if (firstOccureence > -1 && lastOccureence > -1 && pattern.Length > 0)
                {
                    text = text.Remove(lastOccureence, pattern.Length);
                    text = text.Remove(firstOccureence, pattern.Length);
                    messages.AppendLine("Shaked it.");

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                }
                else
                {
                    messages.AppendLine("No shake.");
                    break;
                }
            }

            Console.Write(messages.ToString());
            Console.WriteLine(text);
        }
    }
}