namespace HomeWork_Classes;

public class Phone
{
    public int Number;
    public string Model;
    public double Weight;

    public Phone()
    {
    }

    public Phone(int number, string model)
    {
        Number = number;
        Model = model;
    }

    public Phone(int number, string model, double weight) : this(number, model)
    {
        Weight = weight;
    }

    public void ReceiveCall(string name)
    {
        Console.WriteLine($"Звонит: {name}");
    }

    public int GetNumber()
    {
        return Number;
    }

    public void SendMessage(params int[] phoneNumbers)
    {
        Console.WriteLine(string.Join(", ", phoneNumbers));
    }
}