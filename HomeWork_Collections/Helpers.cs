using System.Collections;
using HomeWork_Collections.FirstTask;

namespace HomeWork_Collections;

public static class Helpers
{
    public static int GetNumberFromConsole()
    {
        string? inputString = Console.ReadLine();
        if (string.IsNullOrEmpty(inputString))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            return GetNumberFromConsole();
        }

        int result;
        if (!int.TryParse(inputString, out result))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            return GetNumberFromConsole();
        }

        return result;
    }

    public static int? GetNumberFromConsoleOrNull()
    {
        string? inputString = Console.ReadLine();
        if (string.IsNullOrEmpty(inputString))
        {
            return null;
        }

        int result;
        if (!int.TryParse(inputString, out result))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            return GetNumberFromConsole();
        }

        return result;
    }
}