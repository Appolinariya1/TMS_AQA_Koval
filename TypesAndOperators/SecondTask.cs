namespace TypesAndOperators;

public static class SecondTask
{
    public static void CheckNumberInIntervals()
    {
        //Задание 2. Проверка попадания числа в интервалы

        Console.Write("Введите число: ");
        int a = Helpers.GetNumberFromConsole();

        if (a > 50 || a < -50)
        {
            Console.WriteLine("Некорректное число");
            return;
        }

        if (a >= -40 && a <= -10)
        {
            Console.WriteLine("Число попадает в промежуток [-40, -10]");
            return;
        }

        if (a >= -9 && a <= 0)
        {
            Console.WriteLine("Число попадает в промежуток [-9, 0]");
            return;
        }

        if (a >= 1 && a <= 10)
        {
            Console.WriteLine("Число попадает в промежуток [1, 10]");
            return;
        }

        if (a >= 11 && a <= 40)
        {
            Console.WriteLine("Число попадает в промежуток [11, 40]");
            return;
        }

        Console.WriteLine("Число не попадает ни в один из заданных интервалов");
    }
}