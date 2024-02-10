using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests.HomeWork;

public class HwFirstTask : BaseTest
{
    [Test]
    public void ValidateSKFTest()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Thread.Sleep(2000);
        Driver.SwitchTo().Frame(0);

        IWebElement ageInput = Driver.FindElement(By.Id("age"));
        ageInput.SendKeys("26");

        SelectElement sexSelect = new SelectElement(Driver.FindElement(By.Id("sex")));
        sexSelect.SelectByText("Женский");

        IWebElement creatinineInput = Driver.FindElement(By.Id("cr"));
        creatinineInput.SendKeys("0,6");

        SelectElement crSizeSelect = new SelectElement(Driver.FindElement(By.Id("cr-size")));
        crSizeSelect.SelectByValue("mg");

        SelectElement raceSelect = new SelectElement(Driver.FindElement(By.Id("race")));
        raceSelect.SelectByIndex(0);

        IWebElement massInput = Driver.FindElement(By.Id("mass"));
        massInput.SendKeys("48");

        IWebElement heightInput = Driver.FindElement(By.Id("grow"));
        heightInput.SendKeys("161");

        IWebElement calcButton = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));
        calcButton.Click();

        Assert.Multiple(() =>
        {
            //По формуле MDRD
            IWebElement mdrdResultElement = Driver.FindElement(By.Id("mdrd_res"));
            Assert.That(mdrdResultElement.Text, Is.EqualTo("120.84"));

            IWebElement mdrdResultLevelElement = Driver.FindElement(By.XPath("//div[@id='mdrd']//span[@class='diagnosis']"));
            Assert.That(mdrdResultLevelElement.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));

            //По формуле CKD-EPI 
            IWebElement ckdEpiResultElement = Driver.FindElement(By.Id("ckd_epi_res"));
            Assert.That(ckdEpiResultElement.Text, Is.EqualTo("125.8"));

            IWebElement ckdEpiResultLevelElement =
                Driver.FindElement(By.XPath("//div[@id='ckd_epi']//span[@class='diagnosis']"));
            Assert.That(ckdEpiResultLevelElement.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));

            //По формуле Кокрофта-Голта
            IWebElement cgeResultElement = Driver.FindElement(By.Id("cge_res"));
            Assert.That(cgeResultElement.Text, Is.EqualTo("107.67"));
        });
    }
}