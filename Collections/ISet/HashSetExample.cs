using Collections.Helper;

namespace Collections.ISet;

public class HashSetExample
{
    public void Run()
    {
        //Создание HashSet для строк
        HashSet<string> uniqueNames = new HashSet<string>(16);
        
        //Добавление элементов
        uniqueNames.Add("Alice");
        uniqueNames.Add("Bob");
        uniqueNames.Add("Tom");
        uniqueNames.Add("Ivan");
        uniqueNames.Add("Alice"); // коллекция может содержать только уникальное значение, повторно этот элемент не будет добавлен
        
        //Вывод элементов
        Console.WriteLine("Unique Names:");
        PrintHelper.PrintCollection(uniqueNames);
        
        // Проверка наличия элемента
        bool containsBob = uniqueNames.Contains("Bob");
        Console.WriteLine($"Contains 'Bob': {containsBob}");

        // Удаление элемента
        uniqueNames.Remove("Alice");

        // Вывод элементов после удаления
        Console.WriteLine("\nNames after removal:");
        PrintHelper.PrintCollection(uniqueNames);
        
        HashSet<string> exceptNames = new HashSet<string>(16);
        //Добавление элементов
        exceptNames.Add("Alice");
        exceptNames.Add("Bob");
        exceptNames.Add("Tom1");

        var differ = uniqueNames.Except(exceptNames);
        // Вывод элементов после сравнения
        Console.WriteLine("\nNames after except:");
        PrintHelper.PrintCollection(differ); 
        
        /*
        uniqueNames.ExceptWith(exceptNames);
        // Вывод элементов после сравнения
        Console.WriteLine("\nNames after ExceptWith:");
        PrintHelper.PrintCollection(uniqueNames);
        */
        
        // Вывод элементов после пересечения
        var uniqueBoth = uniqueNames.Intersect(exceptNames);
        
        // Вывод элементов после Intersect
        Console.WriteLine("\nNames after Intersect:");
        PrintHelper.PrintCollection(uniqueBoth);
        
        // Вывод элементов после объединения
        var uniqueBothUnion = uniqueNames.Union(exceptNames);

        // Вывод элементов после Union
        Console.WriteLine("\nNames after Union:");
        PrintHelper.PrintCollection(uniqueBothUnion);
        
        // Проверка на вхождение множеств
        Console.WriteLine($"IsProperSupersetOf : {uniqueNames.IsProperSupersetOf(exceptNames)}");
        Console.WriteLine($"IsProperSubsetOf : {exceptNames.IsProperSubsetOf(uniqueNames)}");
    }
}