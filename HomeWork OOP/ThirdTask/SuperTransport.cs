namespace HomeWork_OOP.ThirdTask;

public abstract class SuperTransport
{
    private string _destination;
    public string Destination
    {
        get => _destination;
        set => _destination = value;
    }

    private int _number;
    public int Number
    {
        get => _number;
        set => _number = value;
    }
    
    private TimeOnly _departureTime;
    public TimeOnly DepartureTime
    {
        get => _departureTime;
        set => _departureTime = value;
    }
    
    private int _amountSeats;
    public int AmountSeats
    {
        get => _amountSeats;
        set => _amountSeats = value;
    }

    public abstract string? GetTransportType();

    public void WriteTransportInfo() //метод, который нельзя переопределить
    {
        Console.WriteLine($"[{this.GetType().Name}] Number = {Number}, Destination = {Destination}, Departure time = {DepartureTime}, Amount of seat = {AmountSeats}");
    }
}