using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Sorter
{
    public static void Sort<T>(ref CustomList<T> list)
        where T : IComparable<T>
    {
        List<T> sorted = list.OrderBy(e => e).ToList();

        list = new CustomList<T>(sorted);
    }
}