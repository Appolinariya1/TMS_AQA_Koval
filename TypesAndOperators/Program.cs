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

//-------------Двумерный массив------------
int[,] array = new int[4, 5];
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
for (int i = 0; i < array.GetLength(0); i++)
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


foreach (int item in array)
{
    Console.Write($"{item} ");
}
    

