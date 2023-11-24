namespace TypesAndOperators;

public static class ThirdTask
{
    public static void RandomArray()
    {
        Console.Write("Введите желаемый размер массива: ");
        int arraySize = Helpers.GetNumberFromConsole();
        int[] numbers = new int [arraySize];
        for (int i = 0; i <= numbers.GetUpperBound(0); i++)
        {
            numbers[i] = new Random().Next(100);
        }
        if (arraySize == 0)
        {
            Console.WriteLine("В вашем массиве нет места для чисел, я не могу узнать минимальное, среднее и максимальное значения :(");
            return;
        }
        Console.WriteLine($"Создан массив: [{string.Join(", ", numbers)}]");
        int minNumber = numbers[0];
        for (int j = 1; j < numbers.Length; j++)
        {
            if (minNumber > numbers[j])
            {
                minNumber = numbers[j];
            }
        }
        {
            Console.WriteLine($"Минимальное значение из чисел массива = {minNumber} ");
        }
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++ )
        {
            sum += numbers[i];
        }
        int aveNumber = sum / (numbers.Length);
        Console.WriteLine($"Среднее значение из чисел массива = {aveNumber}");
        int maxNumber = numbers[0];
        for (int j = 1; j < numbers.Length; j++)
        {
            if (maxNumber < numbers[j])
            {
                maxNumber = numbers[j];
            }
        }
        {
            Console.WriteLine($"Максимальное значение из чисел массива = {maxNumber} ");
        }
    }
}