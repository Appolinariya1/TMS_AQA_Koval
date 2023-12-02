using Polymorphism;

public class Corporate : Client
{
    public string INN;
    public string UNP;

    public Corporate(int id) : base(id)
    {
        Console.WriteLine("Corporate Base HashCode: " + base.GetHashCode());
    }

    public override sealed void SendNotification() //переопределение. ovveride значит, что мы перегружаем метод, делаем другую реализацию
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }
}