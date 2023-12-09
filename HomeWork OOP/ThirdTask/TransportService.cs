namespace HomeWork_OOP.ThirdTask;

public class TransportService
{
    public void PrintTransportType(SuperTransport transport)
    {
        string? transportType = transport.GetTransportType();
        Console.WriteLine($"[{transport.GetType().Name}] Transport type - {transportType}");
    }

    public SuperTransport[] SortByAmountSeats(SuperTransport[] list)
    {
        for (var i = 0; i < list.Length; i++)
        {
            for (var j = 0; j < list.Length - i - 1; j++)
            {
                if (list[j].AmountSeats > list[j + 1].AmountSeats)
                {
                    var tmp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = tmp;
                }
            }
        }

        return list;
    }
}