// See https://aka.ms/new-console-template for more information

using HomeWork_DelegateEvents.FirstTask;
using HomeWork_DelegateEvents.SecondTask;
using HomeWork_DelegateEvents.ThirdTask;

Console.WriteLine("Задание 1");
var result = new RandomNumberGenerator().Run();
Console.WriteLine($"Результат - {result}");

Console.WriteLine("Задание 2");
var helper = new CircleInfoHelper();

CircleInfoDelegate circledelegate = helper.GetCircleArea;
circledelegate += helper.GetCircleLength;
circledelegate += helper.GetBallVolume;
circledelegate.Invoke(3);

Console.WriteLine("Задание 3");
var random = new Random();
var array = new int[15];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1000);
}

Console.WriteLine("Исходный массив: {0}", string.Join(", ", array));

var helperSort = new SortHelper();
var sortDelegate = helperSort.GetSortDelegateBySortType(SortType.Bubble);
var sortedArray = sortDelegate.Invoke(array);

Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", sortedArray));