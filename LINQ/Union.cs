using LINQ.data;
using LINQ.models;

namespace LINQ;

public class Union
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    private List<int> blackList = new() { -1, -3, 3, 6, 8, 12 };

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        //Не имеет смысла
        var queryResult =
            (from number in _testIntSet
                //Имеет смысл, если делаете какие-то операции или преобразования с исходным множеством
                select number
                )
            .Union(blackList);

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        var queryResult = _testIntSet.Union(blackList);

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }
}