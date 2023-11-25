/* Задание 1
Создайте массив целых чисел.
Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
Пусть число для поиска задается с консоли. */

namespace TypesAndOperators;

public static class FirstTask
{
    public static void CheckNumberIsInArray()
    {
        Console.Write("Введите число: ");
        int inputNumber = Helpers.GetNumberFromConsole();
        int[] numbers = { -5, -4, 0, 4, 5, 100 };
        if (numbers.Contains(inputNumber))
        {
            Console.WriteLine($"Число {inputNumber} входит в массив");
        }
        else
        {
            Console.WriteLine($"Число {inputNumber} не входит в массив");
        }
    }
}