namespace HomeWork.SecondTask;

public class Product : BaseProduct
{
    public DateOnly ManufactureDate;
    public DateOnly ExpirationDate; 

    public Product(string name, double price, DateOnly manufactureDate, DateOnly expirationDate) : base(name, price)
    {
        ManufactureDate = manufactureDate;
        ExpirationDate = expirationDate;
    }

    public override void PrintProductInfo()
    {
        Console.WriteLine($"Наименование: {Name}. Цена: {Price}. Изготовлен {ManufactureDate}. Годен до {ExpirationDate}");
    }

    public override bool CheckExpirationDate()
    {
        return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate;
    }
}