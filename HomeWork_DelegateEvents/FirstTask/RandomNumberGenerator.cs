namespace HomeWork_DelegateEvents.FirstTask;

public class RandomNumberGenerator
{
    private delegate int GetRandomNumber();

    public int Run()
    {
        GetRandomNumber getRandomNumber = GetRandomNumberBelowTen;
        return getRandomNumber();
    }

    public int GetRandomNumberBelowTen()
    {
        var random = new Random();
        return random.Next(10);
    }
}