using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DateModifier
{
    public int CalculateDifference(string date1, string date2)
    {
        int[] date1Arr = date1.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int date1Year = date1Arr[0];
        int date1Month = date1Arr[1];
        int date1Day = date1Arr[2];

        DateTime date1Time = new DateTime(date1Year, date1Month, date1Day);

        int[] date2Arr = date2.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int date2Year = date2Arr[0];
        int date2Month = date2Arr[1];
        int date2Day = date2Arr[2];

        DateTime date2Time = new DateTime(date2Year, date2Month, date2Day);

        return Math.Abs((date1Time - date2Time).Days);
    }
}