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
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            int sumSec = s1 + s2 + s3;
            int min = 0;
            int leftSec = 0;
            if (sumSec < 60)
            {
                min = 0;
                leftSec = sumSec;
            }
            else if (sumSec <= 119 && 60 <= sumSec)
            {
                min = 1;
                leftSec = sumSec - 60;
            }
            else if (120 <= sumSec && 179 >= sumSec)
            {
                min = 2;
                leftSec = sumSec - 120;
            }
            if (leftSec < 10)
            {
                Console.WriteLine("{0}:0{1}", min, leftSec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", min, leftSec);
            }
        }
    }
}
