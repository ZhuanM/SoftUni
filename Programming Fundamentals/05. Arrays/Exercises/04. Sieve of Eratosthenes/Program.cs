using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] prime = new bool[n + 1]; //everything is false by default

            for (int i = 2; i < prime.Length; i++) //setting everything to true
            {
                prime[i] = true;
            }

            for (int i = 0; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        prime[j] = false;
                    }
                    Console.Write(i + " ");
                }
            }
        }
    }
}