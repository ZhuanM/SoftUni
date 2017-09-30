using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var fromV = Console.ReadLine();
            var toV = Console.ReadLine();
            if (fromV.ToLower() == "usd")
            {
                num *= 1.79549;
            }
            else if (fromV.ToLower() == "eur")
            {
                num *= 1.95583;
            }
            else if (fromV.ToLower() == "gbp")
            {
                num *= 2.53405;
            }
            if (toV.ToLower() == "usd")
            {
                num /= 1.79549;
            }
            else if (toV.ToLower() == "eur")
            {
                num /= 1.95583;
            }
            else if (toV.ToLower() == "gbp")
            {
                num /= 2.53405;
            }
            Console.WriteLine("{0:0.00} {1}", num, toV);
        }
    }
}