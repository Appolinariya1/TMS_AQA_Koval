/* Задание 4
Создайте 2 массива из 5 чисел.
Выведите массивы на консоль в двух отдельных строках.
Посчитайте среднее арифметическое элементов каждого массива и сообщите,
для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).*/

namespace TypesAndOperators;

public static class FourthTask
{
    public static void CompareAverageOfTwoArrays()
    {
        var numbers1 = new int[] { 90, -30, -10, 4, 86 };
        var numbers2 = new int[] { 90, -100, 12, 18, -200 };
        Console.WriteLine($"Первый массив = [{string.Join(", ", numbers1)}]");
        Console.WriteLine($"Второй массив = [{string.Join(", ", numbers2)}]");
        int sum1 = 0;
        for (int i = 0; i < numbers1.Length; i++)
        {
            sum1 += numbers1[i];
        }

        int aveNumber1 = sum1 / (numbers1.Length);
        Console.WriteLine($"Среднее значение из чисел первого массива = {aveNumber1}");
        int sum2 = 0;
        for (int i = 0; i < numbers2.Length; i++)
        {
            sum2 += numbers2[i];
        }

        int aveNumber2 = sum2 / (numbers2.Length);
        Console.WriteLine($"Среднее значение из чисел второго массива = {aveNumber2}");

        switch ((aveNumber1, aveNumber2))
        {
            case (_, _) when aveNumber1 > aveNumber2:
                Console.WriteLine("Среднее арифметическое у массива 1 больше, чем у массива 2");
                break;
            case (_, _) when aveNumber1 < aveNumber2:
                Console.WriteLine("Среднее арифметическое у массива 2 больше, чем у массива 1");
                break;
            case (_, _) when aveNumber1 == aveNumber2:
                Console.WriteLine("Средние арифметические массивов равны");
                break;
        }
    }
}