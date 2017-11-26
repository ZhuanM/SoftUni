using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int wormLength = int.Parse(Console.ReadLine()) * 100;
            double wormWidth = double.Parse(Console.ReadLine());

            if (wormLength % wormWidth == 0 || wormWidth == 0)           
                Console.WriteLine($"{wormLength * wormWidth:f2}");
            else
                Console.WriteLine($"{wormLength / (wormWidth / 100):f2}%");
        }
    }
}