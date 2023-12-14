using Collections.Helper;

namespace Collections.IList;

public class LinkedListExample
{
    public void Run()
    {
        // Создаем пустой двусвязный список строк
        LinkedList<string> linkedList = new LinkedList<string>(); //у LinkedList нет Capacity
        
        // Добавляем элементы в конец списка
        linkedList.AddLast("apple");
        linkedList.AddLast("banana");
        linkedList.AddLast("cherry");
        
        //Добавляем элементы в начало списка
        linkedList.AddFirst("orange");
        
        // Выводим элементы списка
        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(linkedList);
        
        // Используем First и Last для получения первого и последнего элемента
        var first = linkedList.First;
        LinkedListNode<string> last = linkedList.Last;
        Console.WriteLine($"Первый элемент: {first.Value}");
        Console.WriteLine($"Последний элемент: {linkedList.Last.Value}");
        
        //Используем Contains для проверки наличия элементов
        bool containsBanana = linkedList.Contains("banana");
        Console.WriteLine($"Список содержит 'banana': {containsBanana}");
        
        // Используем Find для поиска элемента по предикату
        LinkedListNode<string> node = linkedList.Find("banana1");
        Console.WriteLine($"Найденный элемент: {node?.Value}");

        // Вставка перед элементом
        //linkedList.AddBefore(node, "test");
        // Выводим элементы списка
        PrintHelper.PrintCollection(linkedList);
        
        // Используем Remove для удаления элемента
        linkedList.Remove("banana");
        //можем использовать цикл, чтобы удалить все элементы коллекции - while
        
        // Выводим элементы списка
        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(linkedList);
        
        // Используем Clear для очистки списка
        linkedList.Clear();
        
        // Выводим элементы списка
        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(linkedList);
    }
}