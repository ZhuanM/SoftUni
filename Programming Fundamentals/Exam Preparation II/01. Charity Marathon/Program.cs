using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long marathonDays = long.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            long avgLapsPerRunner = long.Parse(Console.ReadLine());
            long lengthOfTrack = long.Parse(Console.ReadLine());
            long capacityOfTrack = long.Parse(Console.ReadLine());
            double donationsPerKm = double.Parse(Console.ReadLine());

            if (runnersCount > capacityOfTrack * marathonDays)
            {
                runnersCount = capacityOfTrack * marathonDays;
            }

            long totalMeters = runnersCount * avgLapsPerRunner * lengthOfTrack;
            double totalKilometers = totalMeters / 1000;
            double moneyRaised = donationsPerKm * totalKilometers;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}