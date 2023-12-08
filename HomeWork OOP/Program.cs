// See https://aka.ms/new-console-template for more information

using HomeWork_OOP.FirstTask;

Console.WriteLine("Задание 1");
Figure[] figures = new Figure[]
{
    TriangleCreator.CreateTriangle(101, 5.5f, 100), //разносторонний треугольник
    TriangleCreator.CreateTriangle(2, 2, 2), //равносторонний треугольник
    TriangleCreator.CreateTriangle(3, 4, 5), // прямоугольный треугольник
    TriangleCreator.CreateTriangle(5, 5, 2), // равнобедренный треугольник
    new Rectangle(4, 5),
    new Square(3)
};

foreach (var figure in figures)
{
    var figureArea = figure.GetArea();
    Console.WriteLine($"Площадь фигуры = {figureArea}"); //можно добавить {figure.GetType()} для проверки фигуры
}
