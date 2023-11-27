/* Задание 3
Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную,
а также всё, что после них во вторую.
Результат вывести в консоль. */

namespace StringApp;

public static class ThirdTask
{
    public static void SplitString()
    {
        string text = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
        string[] parts = text.Split("abc");

        if (parts.Length >= 2) //на случай, если кто-то поменяет текст и уберет abc
        {
            string leftPart = parts[0];
            string rightPart = parts[1];
            Console.WriteLine($"Левая часть: {leftPart}");
            Console.WriteLine($"Правая часть: {rightPart}");
        }
        else
        {
            Console.WriteLine("Некорректная строка");
        }
    }
}