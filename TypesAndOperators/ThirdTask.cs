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
        int arraySize = Helpers.GetNumberFromConsole(true);
        int[] numbers = new int [arraySize];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(100);
        }

        Console.WriteLine($"Создан массив: [{string.Join(", ", numbers)}]");

        int minNumber = numbers[0];
        int maxNumber = numbers[0];
        
        for (int i = 1; i < numbers.Length; i++)
        {
            if (minNumber > numbers[i])
            {
                minNumber = numbers[i];
            }
            if (maxNumber < numbers[i])
            {
                maxNumber = numbers[i];
            }
        }

        int sum = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        int aveNumber = sum / (numbers.Length);
        
        Console.WriteLine($"Минимальное значение из чисел массива = {minNumber} ");
        Console.WriteLine($"Среднее значение из чисел массива = {aveNumber}");
        Console.WriteLine($"Максимальное значение из чисел массива = {maxNumber} ");
    }
}