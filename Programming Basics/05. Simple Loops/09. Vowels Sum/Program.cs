using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];
                if (a == 'a')
                {
                    sum += 1;
                }
                else if (a == 'e')
                {
                    sum += 2;
                }
                else if (a == 'i')
                {
                    sum += 3;
                }
                else if (a == 'o')
                {
                    sum += 4;
                }
                else if (a == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}