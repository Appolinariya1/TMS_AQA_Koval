namespace HomeWork_NUnit;

[TestFixture, Category("Division Cases")]
public class DivideTests
{
    [OneTimeSetUp]
    public void OnetimeSetupForAllTests()
    {
        Console.WriteLine("Настройки перед всеми тестами");
    }

    [SetUp]
    public void SetUpForEachTest()
    {
        Console.WriteLine("Настройка перед каждым тестом");
    }

    [TestCase(5.5, 0.0)]
    [Order(0)]
    [Description("Проверка деления на ноль для чисел double")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Negative")]
    public void CalcDivideByZeroDoubleTest(double x, double y)
    {
        Assert.That(double.IsInfinity(Calculator.Div(x, y)));
    }

    [TestCase(0.0, 0.0)]
    [Order(1)]
    [Description("Проверка деления нуля на ноль для чисел double")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Negative")]
    public void CalcDivideZeroByZeroDoubleTest(double x, double y)
    {
        Assert.That(double.IsNaN(Calculator.Div(x, y)));
    }

    [TestCase(25, 0)]
    [Order(2)]
    [Description("Проверка деления на ноль для целых чисел")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Negative")]
    public void CalcDivideByZeroIntTest(int x, int y)
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Div(x, y));
    }

    [TestCase(25, 5, ExpectedResult = 5)]
    [Order(3)]
    [Description("Проверка деления целых чисел")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Positive")]
    public int CalcDivideIntegersTest(int x, int y)
    {
        return Calculator.Div(x, y);
    }

    [TestCaseSource(typeof(DivideTestData), nameof(DivideTestData.DivideCasesInt))]
    [Order(4)]
    [Description("Проверка деления целых чисел на основе внешних данных")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Positive")]
    public void CalcDivideIntegersFromDbTest(int x, int y, int result)
    {
        Assert.That(Calculator.Div(x, y), Is.EqualTo(result));
    }

    [TestCaseSource(typeof(DivideTestData), nameof(DivideTestData.DivideCasesDouble))]
    [Order(5)]
    [Description("Проверка деления чисел с плавающей запятой на основе внешних данных")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Positive")]
    public void CalcDivideDoubleFromDbTest(double x, double y, double result)
    {
        Assert.That(Calculator.Div(x, y), Is.EqualTo(result));
    }

    [Test]
    [Order(6)]
    [Description("Множественная проверка деления чисел на основе рандомных данных")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Positive")]
    [Repeat(2)] //фактически тест повторяется 4 раза, потому что помимо Repeat у Random стоит count 2
    public void CalcDivideRandomIntegersTest([Random(1, 50, 2)] int x, [Random(1, 50, 2)] int y)
    {
        var result = x / y;
        Assert.That(Calculator.Div(x, y), Is.EqualTo(result));
    }

    [TestCaseSource(typeof(DivideTestData), nameof(DivideTestData.DivideCasesIntIncorrectData))]
    [Ignore("Избыточная проверка")] //если убрать игнор, пасс сработает на 1 наборе ТД из 3
    [Order(7)]
    [Description("Игнорируем этот ТК. Проверка деления чисел с попыткой получить определенный результат")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Retry(5)]
    public void CalcDivideRetryTest(int x, int y, int result)
    {
        if (Calculator.Div(x, y) == result)
        {
            Assert.Pass("Ура! Деление прошло успешно");
        }
        else Assert.Fail("Эти тестовые данные безнадежно испорчены");
    }

    //для одинаковых значений нет смысла использовать combinatorial, но иначе часть тестов упадет
    //а в дз написано использовать все атрибуты :)
    [Test, Combinatorial]
    [Order(8)]
    [Description("Множественная проверка деления чисел на основе комбинированных данных")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Positive")]
    public void CalcDivideCombinatorialTest(
        [Values(2, 2)] int x,
        [Values(2, 2)] int y,
        [Values(1, 1)] int result)
    {
        Assert.That(Calculator.Div(x, y), Is.EqualTo(result));
    }

    [Test, Pairwise]
    [Order(9)]
    [Description("Попарная проверка деления чисел")]
    [Author("Appolinariya", "polina@gmail.com")]
    [Category("Positive")]
    public void CalcDividePairwiseTest(
        [Values(3.0, 3.0)] double x,
        [Values(3.0, 3.0)] double y,
        [Values(1.0, 1.0)] double result)
    {
        Assert.That(Calculator.Div(x, y), Is.EqualTo(result));
    }

    [TearDown]
    public void TearDownForEachTest()
    {
        Console.WriteLine("Убрали настройку после каждого теста");
    }

    [OneTimeTearDown]
    public void OneTimeTearDownForAllTests()
    {
        Console.WriteLine("Закончили все тесты, убрали настройки");
    }
}