using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int percent = N / 2;
            int counter = 0;
            while (N >= M)
            {
                N -= M;

                if (N == percent && Y != 0)
                    N /= Y;

                counter++;
            }

            Console.WriteLine(N);
            Console.WriteLine(counter);
        }
    }
}