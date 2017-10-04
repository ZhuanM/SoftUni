using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hoursMeters = int.Parse(Console.ReadLine());
            int minutesMeters = int.Parse(Console.ReadLine());
            int secondsMeters = int.Parse(Console.ReadLine());

            int time = (hoursMeters * 3600 + minutesMeters * 60 + secondsMeters);

            float metersPerSecond = (float)distanceMeters / time;
            float kilometersPerHour = ((float)distanceMeters / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)distanceMeters / 1609) / ((float)time / 3600);


            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
