namespace HomeWork.SecondTask;

public class Batch : BaseProduct
{
    public List<Product> BatchProduct { get; set; }
    public int Amount;
    //Берем первый элемент, предполагая, что все продукты в партии одинаковые
    public new string? Name => BatchProduct.FirstOrDefault()?.Name;
    public new double Price => BatchProduct.Sum(x => x.Price);
    public DateOnly? ManufactureDate => BatchProduct.FirstOrDefault()?.ManufactureDate;
    public DateOnly? ExpirationDate => BatchProduct.FirstOrDefault()?.ExpirationDate;

    public Batch(List<Product> product)
    {
        BatchProduct = product;
        Amount = product.Count;
    }

    public override void PrintProductInfo()
    {
        Console.WriteLine($"\nПартия продукта {Name} из {Amount} шт. Общая цена продуктов в партии = {Price}. Дата производства {ManufactureDate}, продукты годны до {ExpirationDate}");
    }

    public override bool IsExpired()
    {
        return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate;
    }
}