using System.Threading.Tasks.Dataflow;
using LINQ.data;

namespace LINQ;

public class Join
{
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public record PersonPosition(string FirstName, string Position);
    
    public List<PersonPosition> additionalList = new List<PersonPosition>()
    {
        new PersonPosition("Michel", "QA"),
        new PersonPosition("Oleg", "AQA"),
        new PersonPosition("Alex", "Developer"),
        new PersonPosition("Olga", "HR"), //задвоится, т.к. Имя = не уникальный параметр для сравнения
        new PersonPosition("Stanislav", "QA"),
        new PersonPosition("Tom", "AQA"),
    };

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        var queryResult =
            from person in _testObjectSet
            join person1 in additionalList on person.Name equals person1.FirstName
            select new { person.Name, person.Age, person1.Position };
            //select new { Name = person.Name, Age = person.Age, Position = person1.Position };

            PrintHelper.Print(queryResult, s => Console.WriteLine(s));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        var queryResult = _testObjectSet
            .Join(additionalList,
                person => person.Name, //для сравнения
                person1 => person1.FirstName, //для сравнения
                (person, position) => new { person.Name, person.Age, position.Position }); //то, что нужно создать на основе
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));
    }
}