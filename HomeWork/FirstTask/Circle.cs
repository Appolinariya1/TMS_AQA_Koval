namespace HomeWork.FirstTask;

public class Circle : Figure
{
    public double R;

    public Circle(double r)
    {
        this.R = r;
    }

    public override double GetArea()
    {
        double s = double.Pi * double.Pow(R, 2);
        return s;
    }

    public override double GetPerimeter()
    {
        double p = 2 * double.Pi * R;
        return p;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Круг радиусом {R}");
    }
}