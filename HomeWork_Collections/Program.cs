// See https://aka.ms/new-console-template for more information

using System.Collections;
using HomeWork_Collections;
using HomeWork_Collections.FirstTask;
using HomeWork_Collections.SecondTask;

Console.WriteLine("Задание 1");
Console.WriteLine("Добро пожаловать в бибилотеку!");

ArrayList booksList = new ArrayList
{
    new Book("451 градус по Фаренгейту", "Рэй Брэдбери", 1953),
    new Book("Гарри Поттер и Философский камень", "Джоан Роулинг", 1997),
    new Book("Марсианские хроники", "Рэй Брэдбери", 1950)
};

var exitRequested = false;

while (!exitRequested)
{
    Console.WriteLine(@"
Выберите, что хотите сделать: 
1 - Добавить книгу в бибилотеку
2 - Просмотреть список книг в библиотеке
3 - Найти книгу по автору
4 - Удалить книгу из бибилиотеки
5 - Выйти");

    var action = Helpers.GetNumberFromConsole();

    switch (action)
    {
        case 1:
        {
            Console.WriteLine("Введите название книги: ");
            string? inputName = Console.ReadLine();
            Console.WriteLine("Введите автора книги: ");
            string? inputAuthor = Console.ReadLine();
            Console.WriteLine("Введите год издания книги: ");
            var year = Helpers.GetNumberFromConsole();
            booksList.Add(new Book(inputName, inputAuthor, year));
            break;
        }
        case 2:
        {
            Console.WriteLine("Список всех книг в библиотеке:");
            BookService.PrintBooks(booksList);
            break;
        }
        case 3:
        {
            Console.WriteLine("Введите автора в формате Имя Фамилия");
            string? searchAuthor = Console.ReadLine();
            BookService.FindBook(booksList, searchAuthor);
            break;
        }
        case 4:
        {
            BookService.PrintBooks(booksList);
            Console.WriteLine("Введите номер книги, которую хотите удалить: ");
            var bookIndex = Helpers.GetNumberFromConsole();
            if (bookIndex <= 0 || bookIndex > booksList.Count)
            {
                Console.WriteLine("Книги с таким номером нет в нашей библиотеке!");
                break;
            }

            booksList.RemoveAt(bookIndex - 1);
            Console.WriteLine("Книга успешно удалена!");
            BookService.PrintBooks(booksList);
            break;
        }
        case 5:
        {
            exitRequested = true;
            Console.WriteLine("До свидания!");
            break;
        }
    }
}

Console.WriteLine("\nЗадание 2");
Console.WriteLine("Добро пожаловать в магазин!");
var productService = new ProductService();

exitRequested = false;

while (!exitRequested)
{
    Console.WriteLine(@"
Выберите, что хотите сделать: 
1 - Добавить товар
2 - Просмотреть список товаров в магазине
3 - Найти товар по идентификатору
4 - Обновить информацию о товаре
5 - Удалить товар
6 - Выйти");

    var action2 = Helpers.GetNumberFromConsole();

    switch (action2)
    {
        case 1:
        {
            Console.WriteLine("Введите название товара: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Введите цену: ");
            var price = Helpers.GetNumberFromConsole();
            Console.WriteLine("Введите количество: ");
            var amount = Helpers.GetNumberFromConsole();
            productService.AddProduct(name, price, amount);
            break;
        }
        case 2:
        {
            Console.WriteLine("Список всех товаров: ");
            productService.PrintProductList();
            break;
        }
        case 3:
        {
            Console.WriteLine("Введите идентификатор товара для поиска: ");
            var id = Helpers.GetNumberFromConsole();
            productService.FindProductById(id);
            break;
        }
        case 4:
        {
            Console.WriteLine("Введите идентификатор товара, для которого хотите обновить информацию: ");
            var id = Helpers.GetNumberFromConsole();
            Console.WriteLine("Введите новую цену товара или оставьте поле пустым");
            var price = Helpers.GetNumberFromConsoleOrNull();
            Console.WriteLine("Введите новое количество товара или оставьте поле пустым");
            var amount = Helpers.GetNumberFromConsoleOrNull();
            productService.UpdateProductInfo(id, price, amount);
            break;
        }
        case 5:
        {
            Console.WriteLine("Введите идентификатор товара, который хотите удалить: ");
            var id = Helpers.GetNumberFromConsole();
            productService.DeleteProduct(id);
            break;
        }
        case 6:
        {
            exitRequested = true;
            Console.WriteLine("До свидания!");
            break;
        }
    }
}

Console.WriteLine("\nЗадание 3");
var inputCollection = "1, 2, 3, 4, 4, 5";
Console.WriteLine(string.Join(", ", inputCollection.Split(", ").Distinct()));