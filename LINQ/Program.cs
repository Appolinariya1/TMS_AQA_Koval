// See https://aka.ms/new-console-template for more information

using LINQ;

public class Program
{
    static void Main()
    {
        // Testing Task
        /*
        TestTask testTask = new TestTask();
        testTask.Solve();
        */

        // Base Syntax
        /*
        BaseSyntax baseSyntax = new BaseSyntax();
        baseSyntax.RunQuerySyntax();
        baseSyntax.RunMethodSyntax();
        */

        // Where
        /*
        new Where().RunQuerySyntax();
        new Where().RunMethodSyntax();
        */

        // Select
        /*
        Select select = new Select();
        select.RunQuerySyntax();
        */

        // Два в одном
        new TwoInOne().Run();
    }
}