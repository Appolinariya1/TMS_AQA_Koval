namespace HomeWork_OOP.FirstTask;

public class RightTriangle : BaseTriangle
{
    public RightTriangle(double a, double b, double c) : base(a, b, c)
    {
    }

    public override double GetArea()
    {
        if (A > B && A > C)
        {
            return (B * C) / 2;
        }

        if (B > A && B > C)
        {
            return (A * C) / 2;
        }

        if (C > A && C > B)
        {
            return (A * B) / 2;
        }

        return base.GetArea();
    }
}