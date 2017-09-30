using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";

            string input = Console.ReadLine();
            DateTime inputDate = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);

            DateTime result = inputDate.AddDays(999);

            Console.WriteLine(result.ToString(format));
        }
    }
}
