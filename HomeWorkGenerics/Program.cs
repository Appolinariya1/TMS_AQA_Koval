// See https://aka.ms/new-console-template for more information

using HomeWorkGenerics.FirstTask;
using HomeWorkGenerics.SecondTask;

Console.WriteLine("Задание 1");

var pointInt = new Point<int>(2, 4);
pointInt.Print();

var pointDouble = new Point<double>(2.5, 4.5);
pointDouble.Print();

Console.WriteLine("\nЗадание 2");
Console.WriteLine("Массив с типом int");
{
    var intArray = new GenericArray<int>(new int[] { -5, 0, 1 });
    intArray.Add(3);
    intArray.Add(5);
    intArray.Print();

    intArray.RemoveAt(1);
    intArray.Print();

    int element = intArray.GetAt(3);
    Console.WriteLine($"Элемент по заданному индексу = {element}");

    int arraylength = intArray.GetLength();
    Console.WriteLine($"Длина массива = {arraylength}");
}

Console.WriteLine("\nМассив с типом string");
{
    var strArray = new GenericArray<string>(new string[] { "Кошка", "Мышка" });
    strArray.Add("Кот");
    strArray.Add("Котенок");
    strArray.Print();

    strArray.RemoveAt(1);
    strArray.Print();

    string element1 = strArray.GetAt(0);
    Console.WriteLine($"Элемент по заданному индексу = {element1}");

    int arraylength1 = strArray.GetLength();
    Console.WriteLine($"Длина массива = {arraylength1}");
}