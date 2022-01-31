namespace BenchmarkDotNet;

internal abstract class Shape
{
    //abtract method
    public abstract double area();
    public abstract double Perimeter();
}

internal class Circle : Shape
{
    private double radious;

    public Circle()
    {

    }

    public Circle(double r)
    {
        radious = r;
    }

    public override double area()
    {
        return Math.PI * Math.Pow(radious, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radious;
    }
}

internal class Rectangle : Shape
{
    private double width, length;
    public Rectangle(double w, double l)
    {
        width = w;
        length = l;
    }
    public virtual double Width
    {
        set { width = value; }
    }
    public virtual double Length
    {
        set { length = value; }
    }
    public override double area()
    {
        // Area = width * length
        return width * length;
    }
    public override double Perimeter()
    {
        // Perimeter = 2(width + length)
        return 2 * (width + length);
    }
}

