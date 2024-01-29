// See https://aka.ms/new-console-template for more information

using HomeWork_LINQ.SecondTask;

Console.WriteLine("Задание 1");

var listNumbers = new List<int>() { -5, -4, -3, -2, -2, -1, 0, 1, 2, 3, 3, 3, 4, 5, 6, 6 };
var resultNumbers = listNumbers.Where(number => Math.Abs(number) % 2 == 1).Distinct();
Console.WriteLine(String.Join(", ", resultNumbers));

Console.WriteLine("Задание 2");

var clientsList = new List<Client>()
{
    new Client(1, 2019, 10, 100),
    new Client(2, 2020, 11, 200),
    new Client(3, 2021, 12, 2),
    new Client(4, 2022, 12, 8),
    new Client(5, 2019, 10, 2),
    new Client(6, 2023, 9, 3)
};

var laziestClient = ClientSearchEngine.GetLaziestClient(clientsList);
Console.WriteLine(laziestClient);