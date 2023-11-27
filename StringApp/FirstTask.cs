/* Задание 1:
Заменить в строке все вхождения 'test' на 'testing'.
Удалить из текста все символы, являющиеся цифрами. */

using System.Text.RegularExpressions;

namespace StringApp;

public static class FirstTask
{
    public static void ChangeText()
    {
        string text = "Effective layout of a test case ensures all required actions are completed, improves the readability\n" +
                      "of the test case, and smooths the flow of execution. Consistent structure helps in building a\n" +
                      "self-documenting test case. A commonly applied structure for test cases has (1) setup, (2) execution,\n" +
                      "(3) validation, and (4) cleanup.";
        
        Console.WriteLine($"Исходный текст:\n {text}");
        string text2 = text.Replace("test", "testing");
        var numberRegex = new Regex(@"(\d+)");
        string text3 = numberRegex.Replace(text2, "");
        Console.WriteLine($"Измененный текст:\n {text3}");
    }
}