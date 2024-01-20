namespace NUnitProject;

public class BaseTest
{
    [SetUp]
    public void SetUp1()
    {
        Console.WriteLine($"{this}: Setup1...");
    }
    
    [Test]
    public void Test1()
    {
        Console.WriteLine($"{this}: Test...");
        Assert.Pass();
    }
}