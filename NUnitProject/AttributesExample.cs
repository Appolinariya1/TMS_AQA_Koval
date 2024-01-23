namespace NUnitProject;

[TestFixture, Category("Regression")]
public class AttributesExample
{
    private int x;
    private int i = 0;

    [Test(Description = "Tests for Math Operations")]
    public void DemoTest()
    {
        Console.WriteLine($"{this}: DemoTest... {x++}");
    }

    [Test, Category("Smoke")]
    public void BigTest()
    {
        Console.WriteLine($"{this}: BigTest...{x++}");
    }
    
    [Test, Ignore("Ignoring this test due Isuue")]
    public void AlphaTest()
    {
        Console.WriteLine($"{this}: AlphaTest... {x++}");
    }
    
    [Test, Order(1)]
    public void ZTest()
    {
        Console.WriteLine($"{this}: ZTest... {x++}");
    }

    [Test, Order(2)]
    public void XTest()
    {
        Console.WriteLine($"{this}: XTest... {x++}");
    }
    
    [Test, Order(2)]
    [Author("Jane Doe", "jane.doe@example.com")]
    [Author("Another Developer", "email@example.com")]
    public void AuthorTest()
    {
        Console.WriteLine($"{this}: AuthorTest... {x++}");
    }
    
    [Test, Repeat(5)]
    //[Repeat(5)] - можно вынести отдельно. Категорию и порядок тоже можно так
    public void RepeatTest()
    {
        Console.WriteLine($"{this}: RepeatTest... ");
    }

    [Test]
    [Retry(3)]
    public void RetryTest()
    {
        Console.WriteLine($"{this}: RetryTest... {++i}");
        if (i == 3) Assert.Pass(); //если поставить 4, тест упадет
        else Assert.Fail();
    }

    [Test, MaxTime(2000)]
    public void TimedTest()
    {
        Thread.Sleep(1900); //при 2000 тест падает, т.к. на его запуск тратится доп. время
    }

    [Test]
    public void RandomValuesTest([Random(1, 10, 3)]int randomNumber)
    
    {
        Console.WriteLine($"{this}: RandomValuesTest... {randomNumber} {x++}");
    }
    
    [Test]
    public void RangeValuesTest([Range(1, 5, 2)]int randomNumber)
    
    {
        Console.WriteLine($"{this}: RangeValuesTest... {randomNumber} {x++}");
    }
    
    [Test]
    public void ValuesTest([Values(1, 5, 2)]int intValueNumber)
    
    {
        Console.WriteLine($"{this}: ValuesTest... {intValueNumber} {x++}");
    }

    [Test]
    public void AllValuesTest(
        [Random(1, 10, 3)] int randomNumber,
        [Range(1, 5, 2)] int rangeNumber,
        [Values(1, 5, 2)] int valueNumber)
    {
        Console.WriteLine($"{this}: AllValuesTest...{randomNumber} {x++}");
        Console.WriteLine($"{this}: AllValuesTest...{rangeNumber} {x++}");
        Console.WriteLine($"{this}: AllValuesTest...{valueNumber} {x++}");
    }
    
    [Test, Combinatorial] // Генерирует все возможные пары, используется по умолчанию, можно не писать
    public void CombinatorialTest(
        [Values(1, 2, 3)] int number,
        [Values("A", "B")] string text)
    {
        Console.WriteLine($"{this}: XTest... {number} {text}");
    }
    
    [Test, Pairwise]
    public void PairwiseTest(
        [Values("a", "b", "c")] string a,
        [Values("+", "-")] string b,
        [Values("x", "y")] string c)
    {
        Console.WriteLine("{0} {1} {2}", a, b, c);
    }
    
    //Property
    [Test]
    [Property("Severity", "Critical")]
    public void PropertyTest()
    {
        Console.WriteLine($"{this}: PropertyTest...{TestContext.CurrentContext.Test.Properties.Get("Severity")}");
    }
    
    [Test]
    [Severity(SeverityLevel.Minor)]
    public void AdvancedPropertyTest()
    {
        Console.WriteLine($"{this}: AdvancedPropertyTest...{TestContext.CurrentContext.Test.Properties.Get("Severity")}");
    }
}