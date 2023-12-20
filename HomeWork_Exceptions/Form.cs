using HomeWork_Exceptions.Exceptions;

namespace HomeWork_Exceptions;

public static class Form
{
    public static bool CheckInputInfo(string login, string password, string confirmPassword)
    {
        bool isValidInfo = true;

        if (login.Length >= 20 || login.Contains(' '))
        {
            isValidInfo = false;
            throw new WrongLoginException();
        }

        if (password.Length >= 20 || password.Contains(' ') || password.All(x => !char.IsDigit(x)))
        {
            isValidInfo = false;
            throw new WrongPasswordException("Некорректный ввод. Условия: пароль должен быть длиной меньше 20 символов, без пробелов, с хотя бы одной цифрой");
        }

        if (!string.Equals(password, confirmPassword))
        {
            isValidInfo = false;
            throw new WrongPasswordException("Ошибка! Пароли не совпадают");
        }

        return isValidInfo;
    }
}