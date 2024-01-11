namespace Delegate;

public class PredicateExample //Predicate работает только с одним параметром
{
    public void Run()
    {
        Predicate<int> IsPositive = x => x > 0;
        
        Console.WriteLine(IsPositive(10));
        Console.WriteLine(IsPositive(-10));
    }
}