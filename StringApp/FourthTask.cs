namespace StringApp;

public static class FourthTask
{
    public static void ChangeBadToGood()
    {
        string badDayString = "Плохой день.";
        Console.WriteLine($"Исходная строка: {badDayString}");

        badDayString = badDayString.Substring(6, badDayString.Length - 6);
        string goodDayString = badDayString.Insert(0, "Хороший").Replace(".", "!!!!!!!!!");
        goodDayString = goodDayString.Remove(goodDayString.LastIndexOf('!')).Insert(goodDayString.Length - 1, "?");

        Console.WriteLine($"Измененная строка: {goodDayString}");
    }
}