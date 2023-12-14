// See https://aka.ms/new-console-template for more information

using HomeWork.FirstTask;

Console.WriteLine("Задание 1\nСоздан массив из таких фигур:\n");

double pGeneral = 0;
double sGeneral = 0;

Figure[] figures = new Figure[5]
{
    new Circle(5),
    new Circle(1.5f),
    new Rectangle(4, 5),
    new Rectangle(2.5f, 4),
    new Triangle(3, 5, 4)
};

foreach (var figure in figures)
{
    figure.PrintInfo();
    Console.WriteLine($"Площадь этой фигуры = {Math.Round(figure.GetArea(), 2)}, периметр фигуры = {Math.Round(figure.GetPerimeter(), 2)}");
    pGeneral += figure.GetPerimeter();
    sGeneral += figure.GetArea();
}

Console.WriteLine($"\nПлощадь всех фигур = {Math.Round(sGeneral, 2)}, периметр всех фигур = {Math.Round(pGeneral, 2)}");