namespace TypesAndOperators;

public static class FourthTask
{
    public static void CheckNumberIsEven()
    {
        //Задание 4. Проверка числа на четность

        Console.Write("Введите число: ");
        int userNumber = GetNumberFromConsole();
        var resultFirst = CheckNumberIsEvenFirstMethod(userNumber);
        var resultSecond = CheckNumberIsEvenSecondMethod(userNumber);
        Console.WriteLine($"Проверка первым методом: {(resultFirst ? "Число четное" : "Число нечетное")}");
        Console.WriteLine($"Проверка вторым методом: {(resultSecond ? "Число четное" : "Число нечетное")}");
    }

    // Первый способ
    private static bool CheckNumberIsEvenFirstMethod(int number)
    {
        return number % 2 == 0;
    }

    // Второй способ
    private static bool CheckNumberIsEvenSecondMethod(int number)
    {
        var numberString = number.ToString();
        var lastChar = numberString[numberString.Length - 1];
        return lastChar == '0' || lastChar == '2' || lastChar == '4' || lastChar == '6' || lastChar == '8';
    }

    private static int GetNumberFromConsole()
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
}