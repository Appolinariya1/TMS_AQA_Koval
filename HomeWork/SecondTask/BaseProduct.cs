namespace HomeWork.SecondTask;

public abstract class BaseProduct
{
    public string Name { get; set; }
    public double Price { get; set; }

    protected BaseProduct()
    {
    }

    protected BaseProduct(string name)
    {
        Name = name;
    }

    protected BaseProduct(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void PrintProductInfo();
    public abstract bool IsExpired();
}