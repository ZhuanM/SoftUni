using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rectangle : Shape
{
    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.SideA = sideA;
        this.SideB = sideB;
    }

    public double SideA
    {
        get => this.sideA;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException
                    (nameof(this.SideA), "Side A must be a non-zero and positive");
            }

            this.sideA = value;
        }
    }

    public double SideB
    {
        get => this.sideB;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException
                    (nameof(this.SideB), "Side B must be a non-zero and positive");
            }

            this.sideB = value;
        }
    }

    public override double CalculateArea()
    {
        double area = this.SideA * this.SideB;

        return area;
    }

    public override double CalculatePerimeter()
    {
        double perimeter = (this.SideA + this.SideB) * 2;

        return perimeter;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}