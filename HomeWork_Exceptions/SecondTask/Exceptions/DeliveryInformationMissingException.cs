namespace HomeWork_Exceptions.SecondTask.Exceptions;

public class DeliveryInformationMissingException : Exception
{
    public DeliveryInformationMissingException(string? message) : base(message)
    {
    }
}