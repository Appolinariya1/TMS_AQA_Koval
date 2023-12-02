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

//вспомогательный метод для задания 2
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

/*
Задание 3
Создать класс, описывающий банкомат.
Количество купюр, находящихся в банкомате, должен задаваться тремя
полями: количеством купюр номиналом 20, 50 и 100.

Создать конструктор с тремя параметрами - количеством купюр каждого
номинала.

Реализовать методы:
для добавления денег в банкомат;
для снятия денег - возвращает булевое значение - успешность выполнения операции.

При снятии денег метод должен распечатывать какими купюрами и в каком количестве выдаётся сумма.

 */

//Сценарий проверки 
Console.WriteLine(" \n========= Задание 3 =========");
var atm = new ATM(4, 3, 1); //создаем банкомат
atm.DebugShowAmount(); //проверяем количество купюр в банкомате
atm.PutMoney(1, 1, 1); //кладем купюры в банкомат
atm.DebugShowAmount();
atm.GetMoney(250);
atm.GetMoney(225); //проверяем, что банкомат может выдать только сумму кратную номиналу имеющихся купюр
atm.GetMoney(20);
atm.DebugShowAmount();
atm.GetMoney(230);
atm.DebugShowAmount();
atm.GetMoney(20); //проверяем, что операция не выполняется, когда в банкомате закончились купюры