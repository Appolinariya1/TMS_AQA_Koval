using NUnitTest.Core;
using OpenQA.Selenium;

namespace SeleniumBasic.Tests;

public class SecondTest : BaseTest
{
    [Test]
    public void ValidateIKTCalculationTest1()
    {
        Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");

        IWebElement weightInput = Driver.FindElement(By.Name("weight"));
        IWebElement heightInput = Driver.FindElement(By.Name("height"));
        IWebElement calcButton = Driver.FindElement(By.Id("calc-mass-c"));

        weightInput.SendKeys("48");
        heightInput.SendKeys("161");
        calcButton.Click();

        IWebElement resultText = Driver.FindElement(By.Id("imt-result")); //если поставить раньше, может быть exception, т.к. элемента может еще не быть
        Assert.That(resultText.Text, Is.EqualTo("18.5 - Норма"));
    }
}