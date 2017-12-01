using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsToRemomv = Console.ReadLine();
            string[] words = wordsToRemomv.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in words)
            {
                string newWord = new string('*', word.Length);
                text = text.Replace(word, newWord);
            }

            Console.WriteLine(text);
        }
    }
}