// See https://aka.ms/new-console-template for more information

using HomeWork_Exceptions;
using HomeWork_Exceptions.Exceptions;
using HomeWork_Exceptions.SecondTask;
using HomeWork_Exceptions.SecondTask.Exceptions;

Console.WriteLine("Задание 1");
try
{
    Form.CheckInputInfo("loginlogin", "password0", "password0"); //корректный ввод
    //Form.CheckInputInfo("login login", "password0", "password0"); //некорректный логин, WrongLoginException
    //Form.CheckInputInfo("loginlogin", "password", "password0"); //некорректный пароль, WrongPasswordException
    //Form.CheckInputInfo("loginlogin", "password0", "password1"); //пароли не совпадают, WrongPasswordException
}
catch (WrongLoginException)
{
    Console.WriteLine("Некорректный логин. Условия: логин должен быть длиной меньше 20 символов и без пробелов");
}
catch (WrongPasswordException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\nЗадание 2");
try
{
    var testList1 = new List<Product>() { new Product(1, "Елка", 1000), new Product(2, "Мандарин", 150) };
    var testList2 = new List<Product>() { };
    CreateOrder.CheckOrderInfo(123, testList1, "Марс, Первый кратер"); //корректный ввод
    //CreateOrder.CheckOrderInfo(124, testList2, "Марс, Второй кратер"); //в заказе нет товаров, EmptyOrderException
    //CreateOrder.CheckOrderInfo(-125, testList1, "Марс, Третий кратер"); //номер заказа отрицательный, InvalidOrderNumberException
    //CreateOrder.CheckOrderInfo(126, testList1, ""); //нет данных для доставки, DeliveryInformationMissingException
    Console.WriteLine("Заказ создан успешно");
}
catch (EmptyOrderException e)
{
    Console.WriteLine(e.Message);
}

catch (InvalidOrderNumberException e)
{
    Console.WriteLine(e.Message);
}

catch (DeliveryInformationMissingException e)
{
    Console.WriteLine(e.Message);
}