namespace HomeWork.SecondTask;

public class Set : BaseProduct
{
    public List<Product> SetProducts { get; set; }
    
    public new double Price => SetProducts.Sum(x => x.Price);
    public DateOnly? ExpirationDate => SetProducts.Min(x => x.ExpirationDate);

    public Set(string name, List<Product> products) : base(name)
    {
        SetProducts = products;
    }

    public override void PrintProductInfo()
    {
        Console.WriteLine($"\nКомплект продуктов \"{Name}\". Общая цена комплекта продуктов = {Price}. Состав комплекта:");
        foreach (var product in SetProducts)
        {
            product.PrintProductInfo();
        }
    }

    public override bool CheckExpirationDate()
    {
        return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate;
    }
}