namespace TypesAndOperators;

public static class ThirdTask
{
    public static void TranslateWordsAboutWeather()
    {
        var weatherDictionary = new Dictionary<string, string>()
        {
            { "солнце", "sun" },
            { "ветер", "wind" },
            { "дождь", "rain" },
            { "слякоть", "slush" },
            { "снег", "snow" },
            { "мороз", "frost" },
            { "туман", "fog" },
            { "жара", "heat" },
            { "гололедица", "ice-crusted ground" },
            { "цунами", "tsunami" }
        };
        Console.Write("Введите слово на русском языке: ");
        string? userinput = Console.ReadLine()?.ToLower();
        string? result = null;
        if (userinput != null && weatherDictionary.ContainsKey(userinput))
        {
            result = weatherDictionary[userinput];
        }

        Console.WriteLine(result != null
            ? $"Перевод для слова \"{userinput}\" - \"{result}\""
            : $"Перевод для слова \"{userinput}\" не найден");
    }
}