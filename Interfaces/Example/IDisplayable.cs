namespace Interfaces.Example;

public interface IDisplayable
{
    void DisplayInformation(string information);

    public void DrawBorders()
    {
        Console.WriteLine("Рисуем границу");
    }
}