namespace HomeWork_OOP.FirstTask;

public static class TriangleCreator
{
    public static BaseTriangle CreateTriangle(double a, double b, double c)
    {
        if (a.Equals(0) || b.Equals(0) || c.Equals(0))
        {
            throw new Exception("Невозможно построить треугольник со стороной 0");
        }

        if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
        {
            throw new Exception(
                "Невозможно построить треугольник с заданными сторонами. Для создания треугольника необходимо, чтобы сумма длин двух сторон была больше длины третьей стороны.");
        }

        if (a.Equals(b) && a.Equals(c))
        {
            return new EquilateralTriangle(a, b, c);
        }

        if (
            (a * a).Equals(b * b + c * c) ||
            (b * b).Equals(a * a + c * c) ||
            (c * c).Equals(a * a + b * b)
        )
        {
            return new RightTriangle(a, b, c);
        }

        if (a.Equals(b) || a.Equals(c) || b.Equals(c))
        {
            return new IsoscelesTriangle(a, b, c);
        }

        return new BaseTriangle(a, b, c);
    }
}