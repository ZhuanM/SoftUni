using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPhoenixes = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPhoenixes; i++)
            {
                long lengthOfBody = long.Parse(Console.ReadLine());
                decimal widthOfBody = decimal.Parse(Console.ReadLine());
                int lengthOfWing = int.Parse(Console.ReadLine());

                decimal totalYears = (lengthOfBody * lengthOfBody) * (widthOfBody + 2 * lengthOfWing);

                Console.WriteLine(totalYears);
            }
        }
    }
}