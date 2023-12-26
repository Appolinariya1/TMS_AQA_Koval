namespace HomeWork_Exceptions.SecondTask.Exceptions;

public class InvalidOrderNumberException : Exception
{
    public InvalidOrderNumberException(string? message) : base(message)
    {
    }
}