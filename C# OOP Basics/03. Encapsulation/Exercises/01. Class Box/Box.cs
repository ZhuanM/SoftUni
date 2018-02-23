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

    public double Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public string GetSurfaceArea()
    {
        double surfaceArea = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;

        return $"Surface Area - {surfaceArea:f2}";
    }

    public string GetLateralSurfaceArea()
    {
        double lateralSurfaceArea = 2 * Length * Height + 2 * Width * Height;

        return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
    }

    public string GetVolume()
    {
        double volume = Length * Width * Height;

        return $"Volume - {volume:f2}";
    }
}