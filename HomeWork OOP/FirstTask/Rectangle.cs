namespace HomeWork_OOP.FirstTask;

public class Rectangle : Figure
{
    public double A;
    public double B;
    
    public Rectangle(double a, double b)
    {
        A = a;
        B = b;
    }

    public override double GetArea()
    {
        return A * B;
    }
}