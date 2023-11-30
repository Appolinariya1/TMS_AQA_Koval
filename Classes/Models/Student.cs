namespace Classes.Models;

public class Student
{
    public string name;
    public int group;
    public int diplomMark;

    public void Print()
    {
        Console.WriteLine($"Name: {name}, Group: {group}, Mark: {diplomMark}");
        Console.WriteLine();
    }
}