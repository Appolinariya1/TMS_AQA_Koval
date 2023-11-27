/* Задание 2
Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
Welcome to the TMS lesons.
Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". 
Не забывайте о пробелах после каждого слова */

namespace StringApp;

public static class SecondTask
{
    public static void ConcatenateStrings()
    {
        var greeting = string.Join(" ", new string[] { "Welcome", "to", "the", "TMS", "lessons." });
        Console.WriteLine(greeting);
    }
}