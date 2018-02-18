using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<int> rectCoords = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        Rectangle rectangle = new Rectangle(rectCoords[0], rectCoords[1], rectCoords[2], rectCoords[3]);

        int pointsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < pointsCount; i++)
        {
            List<int> pointCoords = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Point point = new Point(pointCoords[0], pointCoords[1]);

            bool containsPoint = rectangle.Contains(point);

            Console.WriteLine(containsPoint);
        }
    }
}