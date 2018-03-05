using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get => this.radius;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException
                    (nameof(this.Radius), "Circle cannot have a zero or negative radius!");
            }

            this.radius = value;
        }
    }

    public override double CalculateArea()
    {
        double area = Math.PI * this.Radius * this.Radius;

        return area;
    }

    public override double CalculatePerimeter()
    {
        double perimeter = 2 * Math.PI * this.Radius;

        return perimeter;
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}