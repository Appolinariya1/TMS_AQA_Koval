using Collections.Helper;

namespace Collections.IDictionary;

public class DictionaryExample
{
    public void Run()
    {
        // Создаем словарь с ключами и значениями типа string
        Dictionary<string, int> myDictionary = new Dictionary<string, int>(16);
        
        //Добавляем элементы в словарь
        myDictionary.Add("Esma", 10);
        myDictionary.Add("Dika", 5);
        myDictionary.Add("Unknown Cat", 7);
        string key = "Unknown Cat2";
        int value = 7;
        myDictionary.Add("Unknown Cat2", 7);
        
        if (!myDictionary.TryAdd("Esma", 10))
        {
            Console.WriteLine("Данный ключ уже используется");
        }
        
        // Проверяем наличие ключа в словаре
        bool containsKey = myDictionary.ContainsKey("Dika");
        Console.WriteLine($"ContainsKey(\"Dika\"): {containsKey}");
        
        // Проверяем наличие значения в словаре
        Console.WriteLine($"ContainsValue(\"10\"): {myDictionary.ContainsValue(10)}");
        
        // Получаем значение по ключу
        int value1 = myDictionary["Esma"];
        Console.WriteLine($"Value for key 'Esma': {value1}");

        string key1 = "Unknown Cat3"; 
        //Console.WriteLine($"Value for key '{key1}': {myDictionary[key1]}");
        
        int value2;
        if (myDictionary.TryGetValue(key1, out value2))
        {
            Console.WriteLine($"Value for key '{key1}': {value2}");
        }
        else
        {
            Console.WriteLine("Данный ключ отсутствует");
        }
        
        foreach (var key2 in myDictionary.Keys)
        {
            Console.WriteLine($"'{key2}': {myDictionary[key2]}");
        }
        
        // Итерация по парам ключ-значение
        PrintHelper.PrintCollection(myDictionary);
        
        // Удаление элемента по ключу
        myDictionary.Remove("Unknown Cat");
        
        // Выводим элементы после удаления
        Console.WriteLine("Elements after removal:");
        PrintHelper.PrintCollection(myDictionary);

        // Очистка словаря
        myDictionary.Clear();

        // Выводим элементы после очистки
        Console.WriteLine("Elements after clearing:");
        PrintHelper.PrintCollection(myDictionary);
    }
}