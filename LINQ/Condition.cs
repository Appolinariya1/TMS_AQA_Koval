using System.Threading.Tasks.Dataflow;

namespace LINQ;

public class Condition
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // All - все элементы должны соответствовать условию
        bool allResult = _testStringSet.List.All(text => text.Length < 7);
        Console.WriteLine($"Bool All: {allResult}");
        
        // Any - любой из элементов должен соответствовать условию
        allResult = _testStringSet.List.Any(text => text.Length == 2);
        Console.WriteLine($"Bool Any: {allResult}");
        
        //Contains - содержится ли такой элемент
        allResult = _testStringSet.List.Contains("Tom");
        Console.WriteLine($"Bool Contains: {allResult}");
        
        //Методы Join
        
    }
}