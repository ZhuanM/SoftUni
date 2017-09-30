using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double totalPlays = h;
        double normalWeekends = 48 - h;
        totalPlays = totalPlays + (normalWeekends * 0.75);
        totalPlays = totalPlays + (p * 2 / 3);
        if (year == "leap")
        {
            totalPlays = totalPlays + (totalPlays * 0.15);
        }
        Console.WriteLine((int)totalPlays);
    }
}