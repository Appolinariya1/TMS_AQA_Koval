namespace HomeWorkGenerics.FirstTask;

public class Point<T>
{
    private T _x;
    private T _y;

    public T X
    {
        get => _x;
        protected set => _x = value;
    }

    public T Y
    {
        get => _y;
        protected set => _y = value;
    }

    public Point(T x, T y)
    {
        X = x;
        Y = y;
    }

    public void Print()
    {
        Console.WriteLine($"Экземпляр класса с типом в generic {typeof(T)}");
        Console.WriteLine($"Координаты точки - x: {X}, y: {Y}");
    }
}