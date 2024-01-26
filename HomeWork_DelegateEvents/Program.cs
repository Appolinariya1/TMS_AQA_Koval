// See https://aka.ms/new-console-template for more information

using HomeWork_DelegateEvents.FirstTask;
using HomeWork_DelegateEvents.SecondTask;

Console.WriteLine("Задание 1");
var result = new RandomNumberGenerator().Run();
Console.WriteLine($"Результат - {result}");

Console.WriteLine("Задание 2");

var helper = new CircleInfoHelper();

CircleInfoDelegate circledelegate = helper.GetCircleArea;
circledelegate += helper.GetCircleLength;
circledelegate += helper.GetBallVolume;
circledelegate.Invoke(3);