namespace HomeWork_Exceptions.Exceptions;

public class WrongPasswordException : Exception
{
    public WrongPasswordException(string? message) : base(message)
    {
    }
}