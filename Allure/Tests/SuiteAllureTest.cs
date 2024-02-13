using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

[AllureParentSuite("Web Interface")]
[AllureSuite("Essential feature")]
public class SuiteAllureTest : BaseTest
{
    [Test]
    [AllureSubSuite("SubSuite 1")]
    public void SuiteTest()
    {
        Assert.That(true);
    }
    
    [Test]
    public void SuiteTest1()
    {
        AllureApi.AddParentSuite("Web Interface 1");
        AllureApi.AddSuite("Essential feature 1");
        AllureApi.AddSubSuite("SubSuite 2");
        Assert.That(true);
    }
}