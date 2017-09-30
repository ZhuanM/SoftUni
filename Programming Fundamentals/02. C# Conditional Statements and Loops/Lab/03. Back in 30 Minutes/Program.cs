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
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = hours * 60 + minutes;
            int timeInThirtyMinutes = timeInMinutes + 30;

            int timeInThirtyMinutesInHours = timeInThirtyMinutes / 60;
            int timeInThirtyMinutesInMinutes = timeInThirtyMinutes % 60;

            if (timeInThirtyMinutesInHours == 24)
            {
                timeInThirtyMinutesInHours = 0;
            }

            Console.WriteLine($"{timeInThirtyMinutesInHours}:{timeInThirtyMinutesInMinutes:d2}");
        }
    }
}