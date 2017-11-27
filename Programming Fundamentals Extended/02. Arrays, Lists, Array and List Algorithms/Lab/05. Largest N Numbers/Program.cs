using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            List<int> orderByDescendingList = list.OrderByDescending(x => x).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                result.Add(orderByDescendingList[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}