using NUnitTest.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{
    [Test]
    public void ValidateIKTCalculationTest()
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

    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Thread.Sleep(3000);
        Driver.SwitchTo().Frame(1);

        IWebElement selectDropdown = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectElement = new SelectElement(selectDropdown);
        
        selectElement.SelectByIndex(1);
        Thread.Sleep(2000);
        
        selectElement.SelectByValue("mg");
        Thread.Sleep(2000);
        
        selectElement.SelectByText("мкмоль/л");
        Thread.Sleep(2000);
        //объяснение домашки - 1:20 
    }

    [Test]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");
        Thread.Sleep(5000);
        
        Console.WriteLine(Driver.FindElement(By.ClassName("calc-result")).Text);
    }
}