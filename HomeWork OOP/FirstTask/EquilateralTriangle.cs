namespace HomeWork_OOP.FirstTask;

public class EquilateralTriangle : BaseTriangle
{
    public EquilateralTriangle(double a, double b, double c) : base(a, b, c)
    {
    }

    public override double GetArea()
    {
        return double.Sqrt(3) / 4 * double.Pow(A, 2);
    }
}