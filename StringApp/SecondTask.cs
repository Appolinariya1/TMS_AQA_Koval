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
        string[] array = new string[] { "Welcome", "to", "the", "TMS", "lessons." };
        string[] resultarray = new string [array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            resultarray[i] = string.Format("\"{0}\"", array[i]);
        }

        var greeting = string.Join(" ", resultarray);
        Console.WriteLine(greeting);
    }
}