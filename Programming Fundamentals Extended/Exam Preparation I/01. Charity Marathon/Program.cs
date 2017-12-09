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
            int days = int.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            int avgCountOfLaps = int.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long maxRunnerCount = trackCapacity * days;
            if (maxRunnerCount < runnersCount)
            {
                runnersCount = maxRunnerCount;
                long totalMeters = runnersCount * avgCountOfLaps * trackLength;
                long totalKilometers = totalMeters / 1000;
                decimal raisedMoney = moneyPerKm * totalKilometers;
                Console.WriteLine($"Money raised: {raisedMoney:f2}");
            }
            else if (maxRunnerCount >= runnersCount)
            {
                long totalMeters = runnersCount * avgCountOfLaps * trackLength;
                long totalKilometers = totalMeters / 1000;
                decimal raisedMoney = moneyPerKm * totalKilometers;
                Console.WriteLine($"Money raised: {raisedMoney:f2}");
            }
        }
    }
}