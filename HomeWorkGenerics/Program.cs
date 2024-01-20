// See https://aka.ms/new-console-template for more information

using HomeWorkGenerics.FirstTask;

Console.WriteLine("Задание 1");

var pointInt = new Point<int>(2,4);
pointInt.Print();

var pointDouble = new Point<double>(2.5,4.5);
pointDouble.Print();