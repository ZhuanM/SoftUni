using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();

        DateModifier dateModifier = new DateModifier();

        int difference = dateModifier.CalculateDifference(date1, date2);

        Console.WriteLine(difference);
    }
}