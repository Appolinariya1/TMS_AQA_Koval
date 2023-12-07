namespace Interfaces.ExplicitImpl;

public class HeroAction : BaseAction1, IMovable
{
    void IMovable.Move()  //явная имплементация метода из интерфейса
    {
        Console.WriteLine("Move in HeroAction class...");
    }
}