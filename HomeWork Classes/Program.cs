/*
Задание 1:
Создайте класс Phone, который содержит переменные number, model и weight.

Добавить конструкторы в класс Phone:
конструктор без параметров.
принимает на вход два параметра для инициализации переменных класса - number, model.
принимает на вход три параметра для инициализации всех переменных класса Phone. Вызвать из этого конструктора конструктор с двумя параметрами.

Добавить в класс Phone методы:
receiveCall, с одним параметром “имя звонящего”.
Этот метод выводит на консоль сообщение “Звонит {name}”.
getNumber
Этот метод возвращает номер телефона.
sendMessage с аргументами переменной длины.
Этот метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов

Создайте три экземпляра этого класса используя разные конструкторы.
Выведите на консоль значения их переменных.
Вызвать методы receiveCall и getNumber для каждого из объектов.
Вызвать метод sendMessage с 2-мя и 5-ю номерами телефонов.

*/

using HomeWork_Classes;

Phone[] phones = new[]
{
    new Phone(),
    new Phone(8338855, "Iphone3000"),
    new Phone(9666555, "Samsung", 15.5f)
};

Console.WriteLine("=============================");

foreach (var phone in phones)
{
    Console.WriteLine($"Number: {phone.Number}, Model: {phone.Model}, Weight: {phone.Weight}");
}

Console.WriteLine("=============================");

foreach (var phone in phones)
{
    phone.ReceiveCall("Поленька");
    phone.GetNumber();
}

int GetRandomNumber()
{
    return new Random().Next((int)5E6);
}

foreach (var phone in phones)
{
    Console.WriteLine("_____________________________");
    phone.SendMessage(GetRandomNumber(), GetRandomNumber());
    Console.WriteLine("_____________________________");
    phone.SendMessage(
        GetRandomNumber(),
        GetRandomNumber(),
        GetRandomNumber(),
        GetRandomNumber(),
        GetRandomNumber()
    );
}

/*
 Задание 2
Создать класс CreditCard c полями
номер счета,
текущая сумма на счету.

Добавьте методы:
который позволяет зачислять сумму на кредитную карту;
который позволяет снимать некоторую сумму с карты;
который выводит текущую информацию о карточке.

Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма.

Тестовый сценарий для проверки:
Положите деньги на первые две карточки и снимите с третьей.
Выведите на экран текущее состояние всех трех карточек.

*/

Console.WriteLine("\n ========= Задание 2 =========");

CreditCard[] cards = new[]
{
    new CreditCard(10000001, 1000),
    new CreditCard(20000001, 2000),
    new CreditCard(30000001, 3000)
};

Console.WriteLine("Информация по картам до операций");
foreach (var card in cards)
{
    card.CardInfo();
}

Console.WriteLine($"Введите сумму для зачисления на карту {cards[0].AccountNumber}");
cards[0].PutMoney(GetNumberFromConsole(true));

Console.WriteLine($"Введите сумму для зачисления на карту {cards[1].AccountNumber}");
cards[1].PutMoney(GetNumberFromConsole(true));

Console.WriteLine($"Введите сумму для снятия с карты {cards[2].AccountNumber}");
cards[2].GetMoney(GetNumberFromConsole(true));

Console.WriteLine("Информация по картам после проведенных операций");
foreach (var card in cards)
{
    card.CardInfo();
}

//вспомогательный метод
static int GetNumberFromConsole(bool onlyPositive = false)
{
    string? inputString = Console.ReadLine();
    
    if (string.IsNullOrEmpty(inputString))
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        return GetNumberFromConsole(onlyPositive);
    }

    int result;
    
    if (!int.TryParse(inputString, out result))
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        return GetNumberFromConsole(onlyPositive);
    }

    if (onlyPositive && result <= 0)
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое положительное число");
        return GetNumberFromConsole(onlyPositive);
    }

    return result;
}