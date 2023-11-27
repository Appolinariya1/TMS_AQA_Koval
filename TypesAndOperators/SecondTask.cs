/* Задание 2
Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
Пусть число задается с консоли. Если такого числа нет - выведите сообщение об этом.
В результате должен быть новый массив без указанного числа.*/

namespace TypesAndOperators;

public static class SecondTask
{
    public static void ChangeArray()
    {
        int[] numbers = { -3, -2, 99, 0, 2, 99, 3, 99, 99, 99 };
        
        Console.WriteLine($"Исходный массив: [{string.Join(", ", numbers)}]");
        Console.Write("Введите число, которое хотите удалить: ");
        
        int inputNumber = Helpers.GetNumberFromConsole();
        int[] numbersFiltered = new int [numbers.Length];
        int filteredIndex = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != inputNumber)
            {
                numbersFiltered[filteredIndex] = numbers[i];
                filteredIndex++;
            }
        }

        if (filteredIndex == numbers.Length)
        {
            Console.WriteLine($"Числа {inputNumber} нет в заданном массиве");
            return;
        }

        var resultNumbers = new int[filteredIndex];
        
        for (int i = 0; i < resultNumbers.Length; i++)
        {
            resultNumbers[i] = numbersFiltered[i];
        }
        
        Console.WriteLine($"Новый массив: [{string.Join(", ", resultNumbers)}]");
    }
}