namespace HomeWork_OOP.ThirdTask;

public abstract class SuperTransport
{
    public string Destination { get; set; }
    public int Number { get; set; }
    public TimeOnly DepartureTime { get; set; }
    public int AmountSeats { get; set; }

    public abstract string? GetTransportType();

    public void WriteTransportInfo() //метод, который нельзя переопределить
    {
        Console.WriteLine($"[{this.GetType().Name}] Number = {Number}, Destination = {Destination}, Departure time = {DepartureTime}, Amount of seats = {AmountSeats}");
    }
}