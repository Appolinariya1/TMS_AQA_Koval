namespace TypesAndOperators;

public static class Helpers
{
    public static int GetNumberFromConsole(bool onlyPositive = false)
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
}