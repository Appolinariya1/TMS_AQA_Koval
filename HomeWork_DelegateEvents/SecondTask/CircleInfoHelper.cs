namespace HomeWork_DelegateEvents.SecondTask;

public class CircleInfoHelper
{
    public double GetCircleLength(double r)
    {
        var d = 2 * Math.PI * r;
        Console.WriteLine($"d = {d}");
        return d;
    }

    public double GetCircleArea(double r)
    {
        var s = Math.PI * r * r;
        Console.WriteLine($"s = {s}");
        return s;
    }

    public double GetBallVolume(double r)
    {
        var v = Math.PI * Math.Pow(r, 3) * 4 / 3;
        Console.WriteLine($"v = {v}");
        return v;
    }
}