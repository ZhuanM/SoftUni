using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            double resultDistance = (N / 1000) * M;
            double seconds = N / 100;

            double resultSeconds = ((N / P) * 5) + seconds;

            Console.WriteLine($"{resultDistance:f2} m.");
            Console.WriteLine($"{resultSeconds} s.");
        }
    }
}