namespace Classes.Models;

public class Person
{
    // Блок полей переменных
    public string name = "Undefined"; //имя
    public int age; // возраст
    public int surname; //фамилия

    // Блок методов и свойств
    public void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}