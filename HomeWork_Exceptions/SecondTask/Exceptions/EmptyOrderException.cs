namespace HomeWork_Exceptions.SecondTask.Exceptions;

public class EmptyOrderException : Exception
{
    public EmptyOrderException(string? message) : base(message)
    {
    }
}