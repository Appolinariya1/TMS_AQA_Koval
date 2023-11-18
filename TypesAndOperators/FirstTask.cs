namespace TypesAndOperators;

public static class FirstTask
{
    public static void Calculator()
    {
        //Задание 1. Консольный калькулятор

        Console.Write("Введите первое число: ");
        int a = GetNumberFromConsole();
        Console.Write("Введите допустимую операцию (+, -, *, /): ");
        string b = GetOperationSignFromConsole();
        Console.Write("Введите второе число: ");
        int c = GetNumberFromConsole();
        int? result = null;
        switch (b)
        {
            case "+":
                result = a + c;
                break;
            case "-":
                result = a - c;
                break;
            case "*":
                result = a * c;
                break;
            case "/":
                if (c == 0)
                {
                    Console.WriteLine("На 0 делить нельзя! Даже если очень хочется :)");
                    break;
                }

                result = a / c;
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                break;
        }

        if (result != null)
        {
            Console.WriteLine($"Результат: {result}");
        }
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

    private static string GetOperationSignFromConsole()
    {
        string? inputString = Console.ReadLine();
        if (string.IsNullOrEmpty(inputString))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите знак операции.");
            return GetOperationSignFromConsole();
        }

        if (!(inputString == "+" || inputString == "-" || inputString == "*" || inputString == "/"))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите знак операции.");
            return GetOperationSignFromConsole();
        }

        return inputString;
    }
}