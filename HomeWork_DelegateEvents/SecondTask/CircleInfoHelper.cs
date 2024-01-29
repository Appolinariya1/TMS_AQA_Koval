namespace HomeWork_DelegateEvents.SecondTask;

public class CircleInfoHelper
{
    public double GetCircleLength(double radius)
    {
        var circleLength = 2 * Math.PI * radius;
        Console.WriteLine($"Длина окружности = {circleLength}");
        return circleLength;
    }

    public double GetCircleArea(double radius)
    {
        var circleArea = Math.PI * radius * radius;
        Console.WriteLine($"Площадь круга = {circleArea}");
        return circleArea;
    }

    public double GetBallVolume(double radius)
    {
        var ballVolume = Math.PI * Math.Pow(radius, 3) * 4.0 / 3.0;
        Console.WriteLine($"Объем шара = {ballVolume}");
        return ballVolume;
    }
}