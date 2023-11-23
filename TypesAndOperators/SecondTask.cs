namespace TypesAndOperators;

public static class SecondTask
{
    public static void ChangeArray()
    {
        Console.Write("Введите число: ");
        int inputNumber = Helpers.GetNumberFromConsole();
        int[] numbers = { -3, -2, 99, 0, 2, 99, 3, 99, 99, 99 };


        int[] numbersFiltered = new int [numbers.Length];

        int offset = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != inputNumber)
            {
                numbersFiltered[i - offset] = numbers[i];
            }
            else
            {
                offset++;
            }
        }

        if (offset == 0)
        {
            Console.WriteLine($"Числа {inputNumber} нет в заданном массиве");
            return;
        }

        var resultNumbers = new int[numbers.Length - offset];
        for (int i = 0; i < resultNumbers.Length; i++)
        {
            resultNumbers[i] = numbersFiltered[i];
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Новый массив: [{string.Join(", ", resultNumbers)}]");
    }
}