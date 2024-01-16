using LINQ.data;
using LINQ.models;

namespace LINQ;

public class Aggregation
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Aggregate - в Query не используется
        // Sum - в Query не используется
        // GroupBy
        var queryResult =
            from obj in _testObjectSet
            group obj by obj.Age;

        foreach (var item in queryResult)
        {
            Console.WriteLine($"{item.Key}");

            foreach (var subItem in item)
            {
                Console.WriteLine($"{subItem.Name} {subItem.Age}");
            }
        }

        var queryResult1 =
                from obj in _testObjectSet
                group obj by obj.Age
                into gen
                select new
                {
                    Age = gen.Key,
                    Count = gen.Count()
                };

        foreach(var item in queryResult1)
        {
            Console.WriteLine($"{item.Age} : {item.Count}");
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // Aggregate
        var queryResult = _testIntSet.Aggregate((x, y) => x - y);
        var queryResult1 = _testIntSet.Aggregate(10, (acc, i) => acc + i);

        Console.WriteLine($"queryResult: {queryResult}");
        Console.WriteLine($"queryResult1: {queryResult1}");

        // Sum
        var queryResult3 = _testIntSet.Sum();
        var queryResult31 = _testObjectSet.Sum(person => person.Age);

        Console.WriteLine($"queryResult: {queryResult3}");
        Console.WriteLine($"queryResult31: {queryResult31}");

        // Max, Min, Average
        queryResult3 = _testIntSet.Max();
        queryResult3 = _testIntSet.Min();
        var queryResult32 = _testIntSet.Average();
    }
}
