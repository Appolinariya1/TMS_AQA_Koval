namespace HomeWork_OOP.FirstTask;

public class Square : Rectangle
{
    public Square(double a) : base(a, a)
    {
    }

    public override double GetArea()
    {
        return A * A;
    }
}