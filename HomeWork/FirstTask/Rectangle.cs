namespace HomeWork.FirstTask;

public class Rectangle : Figure
{
    public double A;
    public double B;

    public Rectangle(double a, double b)
    {
        this.A = a;
        this.B = b;
    }

    public override double GetArea()
    {
        double s = A * B;
        return s;
    }

    public override double GetPerimeter()
    {
        double p = (A + B) * 2;
        return p;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Прямоугольник со сторонами {A} и {B}");
    }
}