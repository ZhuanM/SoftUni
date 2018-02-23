using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box
{
    private double length;
    private double width;
    private double height;

    private double Length
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }

            this.length = value;
        }
    }

    private double Width
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            this.width = value;
        }
    }

    private double Height
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public string GetSurfaceArea()
    {
        double surfaceArea = 2 * length * width + 2 * length * height + 2 * width * height;

        return $"Surface Area - {surfaceArea:f2}";
    }

    public string GetLateralSurfaceArea()
    {
        double lateralSurfaceArea = 2 * length * height + 2 * width * height;

        return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
    }

    public string GetVolume()
    {
        double volume = length * width * height;

        return $"Volume - {volume:f2}";
    }
}