namespace HomeWork_Collections.SecondTask;

public class ProductService
{
    private readonly Dictionary<int, Product> _productList;

    public ProductService()
    {
        _productList = new Dictionary<int, Product>();

        string[] productNames = new[] { "телевизор", "ноутбук", "мышь", "наушники", "монитор" };
        var rand = new Random();
        foreach (var product in productNames)
        {
            AddProduct(product, rand.Next(100, 500000), rand.Next(0, 1000));
        }
    }

    public void AddProduct(string name, int price, int amount)
    {
        _productList.Add(_productList.Keys.Count != 0
            ? _productList.Keys.Max() + 1
            : 0, new Product(name, price, amount));
    }

    public void PrintProductList()
    {
        foreach (var product in _productList)
        {
            PrintProductInfo(product.Key, product.Value);
        }
    }

    private void PrintProductInfo(int id, Product product)
    {
        Console.WriteLine($"{id}, название \"{product.Name}\", цена {product.Price}, количество {product.Amount}");
    }


    public void FindProductById(int id)
    {
        var result = _productList.TryGetValue(id, out var product);
        if (result && product != null)
        {
            Console.WriteLine($"Товар успешно найден.");
            PrintProductInfo(id, product);
        }
        else
        {
            Console.WriteLine($"Товар с идентификатором {id} не найден!");
        }
    }

    public void UpdateProductInfo(int id, int? price, int? amount)
    {
        var result = _productList.TryGetValue(id, out var product);
        if (result && product != null)
        {
            if (price != null)
            {
                product.Price = price.Value;
            }

            if (amount != null)
            {
                product.Amount = amount.Value;
            }

            Console.WriteLine($"Товар с идентификатором {id} обновлен:");
            PrintProductInfo(id, product);
        }
        else
        {
            Console.WriteLine($"Товар с идентификатором {id} не найден!");
        }
    }

    public void DeleteProduct(int id)
    {
        if (_productList.ContainsKey(id))
        {
            _productList.Remove(id);
            Console.WriteLine($"Товар с идентификатором {id} удален.");
        }
        else
        {
            Console.WriteLine($"Товар с идентификатором {id} не найден!");
        }
    }
}