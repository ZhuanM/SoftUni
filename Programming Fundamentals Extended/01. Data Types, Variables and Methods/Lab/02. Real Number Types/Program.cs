using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Real_Number_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 16)
                Console.WriteLine(double.Parse(Console.ReadLine()));
            else if (n < 29)
                Console.WriteLine(decimal.Parse(Console.ReadLine()));
        }
    }
}