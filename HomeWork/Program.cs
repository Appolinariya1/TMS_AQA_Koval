// See https://aka.ms/new-console-template for more information

using HomeWork.FirstTask;
using HomeWork.SecondTask;

Console.WriteLine("Задание 1\nСоздан массив из фигур:\n");

double pGeneral = 0;
double sGeneral = 0;

Figure[] figures = new Figure[]
{
    new Circle(5),
    new Circle(1.5f),
    new Rectangle(4, 5),
    new Rectangle(2.5f, 4),
    new Triangle(3, 5, 4)
};

foreach (var figure in figures)
{
    figure.PrintInfo();
    Console.WriteLine($"Площадь этой фигуры = {Math.Round(figure.GetArea(), 2)}, периметр фигуры = {Math.Round(figure.GetPerimeter(), 2)}");
    pGeneral += figure.GetPerimeter();
    sGeneral += figure.GetArea();
}

Console.WriteLine($"\nПлощадь всех фигур = {Math.Round(sGeneral, 2)}, периметр всех фигур = {Math.Round(pGeneral, 2)}");

Console.WriteLine("\nЗадание 2\nНа нашем складе есть товары:");

var productsDb = new List<BaseProduct>();

productsDb.AddRange( new BaseProduct[]
{
    new Product("Колбаса", 400, new DateOnly(2023, 12, 10), new DateOnly(2024, 01, 10)),
    new Product("Хлеб", 40, new DateOnly(2023, 12, 15), new DateOnly(2023, 12, 25)),
    new Product("Молоко", 110, new DateOnly(2022, 12, 16), new DateOnly(2022, 12, 19)),
    
    new Batch(new List<Product>()
    {
        new Product("Сыр", 605, new DateOnly(2023, 12, 01), new DateOnly(2024, 01, 01)),
        new Product("Сыр", 605, new DateOnly(2023, 12, 01), new DateOnly(2024, 01, 01)),
        new Product("Сыр", 605, new DateOnly(2023, 12, 01), new DateOnly(2024, 01, 01))
    }),
    
    new Set("Веселая пятница", new List<Product>()
    {
        new Product("Егермейстер", 1500, new DateOnly(2023, 12, 01), new DateOnly(3000, 01, 01)),
        new Product("Яблочный сок", 200, new DateOnly(2023, 11, 01), new DateOnly(2024, 01, 01))
    })
});

foreach (var product in productsDb)
{
    product.PrintProductInfo();
}

foreach (var product in productsDb)
{
    if (product.IsExpired())
    {
        Console.Write("\nНайден просроченный продукт: ");
        product.PrintProductInfo();
    }
}