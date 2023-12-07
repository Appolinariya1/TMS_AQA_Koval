namespace Interfaces.ExplicitImpl;

public class NewAction : IAction, IMovable
{
    void IAction.Move()
    {
        Console.WriteLine("IAction");
    }

    void IMovable.Move()
    {
        Console.WriteLine("IMovable");
    }
}