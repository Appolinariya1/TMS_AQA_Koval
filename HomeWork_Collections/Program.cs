// See https://aka.ms/new-console-template for more information

using System.Collections;
using HomeWork_Collections;
using HomeWork_Collections.FirstTask;

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