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
            var badWords = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var text = Console.ReadLine();

            foreach (var badWord in badWords)
            {
                if (text.Contains(badWord))
                {
                    text = text.Replace(badWord, new string('*', badWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}