/*int[] array = { 1, 9, 3, 6, 5 };
///
///
///
///
///
///
int[] array1;
int n = 4;
array1 = new int[n]; //размерность можно определить только при инициализации массива, потом изменить нельзя
int[] array2 = new int[5] { 1, 9, 3, 6, 5 };

//Console.WriteLine(array[4]);                       // количество всех элементов
//array[0] = 10;

Console.WriteLine($"Last item in array: {array[array.Length - 2]}");
Console.WriteLine($"Last item in array: {array[^2]}");
Console.WriteLine($"Last item in array: {array[array.GetUpperBound(0)]}"); //самый правильный варинт из этих трех, где указываем строку, с которой работаем

Console.WriteLine(array[0]);
Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array.Rank);                           // ранг массива
Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetUpperBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк


for (int i = 0; i < array.GetLength(0) ; i++) //(объявление переменной; условие; изменение переменной)
{
Console.Write($"{array[i]}");
}

for (int i = 0; i <= array.GetUpperBound(0) ; i++) //считается по индексу, а не по количеству элементов, поэтому <=
{
Console.Write($"{array[i]}");
}


for (int i = 0; i <= array.GetUpperBound(0) ; i++)
{
array[i] = new Random().Next(100);
}

Console.WriteLine();
foreach (int item in array) //указать тип массива, с которым мы работаем
{
Console.Write($"{item} ");
}

//for - работает с индексами при работе с массивами; позволяет менять значение элементов
//foreach - работает с элементами массива. Можно только получить, менять нельзя

for (int i = 1; i <= 10; i++) //меняет переменную на шаг, укзаанный в конце до тех пор, пока условие из середины не будет выполнено
{
Console.WriteLine($"{i} Hello");
}

for (int i = 0; i <= 10; i += 2)  //вычисление чисел от нуля до 10

{
Console.WriteLine($"{i} ");
}

Console.WriteLine();
string text = "Hello!!!";
foreach (char ch in text)
{
Console.Write($"{ch} ");
}

for (int i = 0; i <= 10; i += 2)  //вычисление цифр от нуля до 10, если цифра не равна 6, ничего не выводить

{
if (i != 6)
{

}
else
{
    Console.WriteLine($"{i} ");
}

}


int u = 6;
bool flag = true;

do //цикл выполнится минимум один раз (в отличие for, который может не выполниться ни разу при соотв. условии
{
    if (u < 0) flag = false;
    Console.WriteLine($"{u}");
    u--;
}
while (flag);

int u1 = 6;
do
{

    Console.WriteLine($"{u1}");
    u1--;
}
while (u1 >= 0);
*/
/*
//-------------Двумерный массив------------
int[,] array = new int[4, 5]; //запятая значит, что это двумерный массив - 4 строки по 5 элементов
int[,] array1 =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};


Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array.Rank);                           // ранг массива
Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetLength(1): " + array.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array.GetUpperBound(1));   // Верхний индекс столбцов
Console.WriteLine("GetLowerBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " + array.GetLowerBound(1));   // Нижний индекс столбцов



Console.WriteLine("=========");

int t = 1;
// Задание значений
for (int i = 0; i < array.GetLength(0); i++) //GetLength завязан на измерения, как и Upper/LowerBound. Можно использовать или GetLength или UpperBound по желанию
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
    }
}

int rows = array.GetLength(0);
int columns = array.Length / rows;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}


foreach (int item in array) //нельзя изменить, но можно получить какое-то значение из массива
{
    Console.Write($"{item} ");
}


// -============================================= Трехмерный массив =============================================-

int[,,] array3D = new int[,,]
{
    {
        { 1, 2, 3 },
        { 4, 5, 6 }
    },
    {
        { 7, 8, 9 },
        { 10, 11, 12 }
    }
};

Console.WriteLine("Length: " + array3D.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array3D.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array3D.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array3D.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetLength(1): " + array3D.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array3D.GetUpperBound(1));   // Верхний индекс столбцов
Console.WriteLine("GetLength(2): " + array3D.GetLength(2));           // количество столбцов
Console.WriteLine("GetUpperBound(2): " + array3D.GetUpperBound(2));   // Верхний индекс столбцов

Console.WriteLine("GetLowerBound(0): " + array3D.GetLowerBound(0));   // Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " + array3D.GetLowerBound(1));   // Нижний индекс столбцов
Console.WriteLine("GetLowerBound(2): " + array3D.GetLowerBound(2));   // Нижний индекс столбцов

for (int i = 0; i <= array3D.GetUpperBound(0); i++)
{
    Console.WriteLine($"-========= Level {i} ==========-");
    for (int j = 0; j <= array3D.GetUpperBound(1); j++)
    {
        for (int k = 0; k <= array3D.GetUpperBound(2); k++)
        {
            Console.Write($"{array3D[i, j, k]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"-============================-");
}
*/

//================= Многомерный (зубчатый) массив ======================
/*
int[][] numbers =
{
    new int[] { 1, 2 },
    new int[] { 1, 2, 3, 4, 5 },
    new int[] { 1, 2, 3 }
};

Console.WriteLine("Length: " + numbers.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + numbers.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + numbers.GetLength(0));           // количество строк
Console.WriteLine("GetLength(0): " + numbers.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + numbers.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("============================");


foreach (int[] row in numbers)
{
    for (int i = 0; i < row.Length; i++)
    {
        row[i] = new Random().Next(100);
    }
}

for (int i = 0; i <= numbers.GetUpperBound(0); i++)
{
    for (int j = 0; j <= numbers[i].GetUpperBound(0); j++)
    {
        Console.Write($"{numbers[i][j]} \t");
    }

    Console.WriteLine();
}
*/


//===== Задача перевернуть массив =====

int[] nums = { -4, 8, 10, 2, 12, 0, 5, 6};

foreach (int item in nums)
{
    Console.Write($"{item} \t");
}

Console.WriteLine();
/*
nums[0] <-> nums[nums.Length - 1 - 0]
nums[1] <-> nums[nums.Length - 1 - 1]
nums[2] <-> nums[nums.Length - 1 - 2]
*/

int n = nums.Length; //Длина массива
int k = n / 2;
int tmp;

for (int i = 0; i < k; i++)
{
    tmp = nums[i];
    nums[i] = nums[n - 1 - i];
    nums[n - 1 - i] = tmp;
}
foreach (int item in nums)
{
 Console.Write($"{item} \t");
}

Array.Reverse(nums);

foreach (int item in nums)
{
    Console.Write($"{item} \t");
}

