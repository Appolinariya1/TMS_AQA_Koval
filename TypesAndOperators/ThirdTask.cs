/* Задание 3
Создайте и заполните массив случайными числами и выведите максимальное, минимальное и среднее значение.
Для генерации случайного числа используйте метод Random() .
Пусть будет возможность создавать массив произвольного размера.
Пусть размер массива вводится с консоли. */

namespace TypesAndOperators;

public static class ThirdTask
{
    public static void RandomArray()
    {
        Console.Write("Введите желаемый размер массива: ");
        int arraySize = Helpers.GetNumberFromConsole();
        int[] numbers = new int [arraySize];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(100);
        }

        if (arraySize == 0)
        {
            Console.WriteLine(
                "В вашем массиве нет места для чисел, я не могу узнать минимальное, среднее и максимальное значения :(");
            return;
        }

        Console.WriteLine($"Создан массив: [{string.Join(", ", numbers)}]");

        int minNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (minNumber > numbers[i])
            {
                minNumber = numbers[i];
            }
        }

        Console.WriteLine($"Минимальное значение из чисел массива = {minNumber} ");

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        int aveNumber = sum / (numbers.Length);
        Console.WriteLine($"Среднее значение из чисел массива = {aveNumber}");

        int maxNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (maxNumber < numbers[i])
            {
                maxNumber = numbers[i];
            }
        }

        Console.WriteLine($"Максимальное значение из чисел массива = {maxNumber} ");
    }
}