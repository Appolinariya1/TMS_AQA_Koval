using LINQ.data;

namespace LINQ;

public class Variables
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        //Создание временных переменных
        var queryResult =
            from person in _testObjectSet
            let yearOfBirth = DateTime.Now.Year - person.Age
            let flag = true
            select new
            {
                Firstname = person.Name, //заменяем имя поля в новой структуре
                YearOfBirth = yearOfBirth,
                Flag = flag
            };

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        //Создание временных переменных
        var queryResult = _testObjectSet
                .Select(person => new { person.Name, YearOfBirth = DateTime.Now.Year - person.Age });

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }
}