using System.Text.RegularExpressions;

namespace StringApp;

public class SixthTask
{
    public static void ClearText()
    {
        var path = "sample.txt";
        var text = File.ReadAllText(path);
        Console.WriteLine($"Исходный текст:\n{text}");

        var spacesRegex = new Regex(@"\t");
        var text2 = spacesRegex.Replace(text, " "); //замена знаков табуляции на пробел
        var charRegex = new Regex(@"(\s+)");
        string text3 = charRegex.Replace(text2, " ");

        Console.WriteLine($"Отредактированный текст:\n{text3}");
    }
}