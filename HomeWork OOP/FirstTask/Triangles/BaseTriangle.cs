namespace HomeWork_OOP.FirstTask;

public class BaseTriangle : Figure
{
    public double A;
    public double B;
    public double C;

    private double P => (A + B + C) / 2;
    
    public BaseTriangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double GetArea() //расчет площади по формуле Герона
    {
        return double.Sqrt(P * (P - A) * (P - B) * (P - C));
    }
}