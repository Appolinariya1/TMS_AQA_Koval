using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

public class AllureTest : BaseTest
{
    [Test(Description = "Some detailed test description")]
    public void TestDescription()
    {
        Assert.That(true);
    }

    [Test]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestSeverity()
    {
        Assert.That(true);
    }
}