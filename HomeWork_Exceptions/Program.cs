// See https://aka.ms/new-console-template for more information

using HomeWork_Exceptions;
using HomeWork_Exceptions.Exceptions;

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