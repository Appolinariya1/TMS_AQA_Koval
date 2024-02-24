using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests.HomeWork;

public class HwSecondTask : BaseTest
{
    [Test]
    public void ValidateLaminateCalcTest()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        IWebElement lengthRoomInput = Driver.FindElement(By.Id("ln_room_id"));
        lengthRoomInput.Clear();
        lengthRoomInput.SendKeys("500");

        IWebElement widthRoomInput = Driver.FindElement(By.Id("wd_room_id"));
        widthRoomInput.Clear();
        widthRoomInput.SendKeys("300");

        IWebElement lengthLaminateInput = Driver.FindElement(By.Id("ln_lam_id"));
        lengthLaminateInput.Clear();
        lengthLaminateInput.SendKeys("1150");

        IWebElement widthLaminateInput = Driver.FindElement(By.Id("wd_lam_id"));
        widthLaminateInput.Clear();
        widthLaminateInput.SendKeys("300");

        IWebElement laminateCountInput = Driver.FindElement(By.Id("n_packing"));
        laminateCountInput.Clear();
        laminateCountInput.SendKeys("20");

        IWebElement laminateAreaInput = Driver.FindElement(By.Id("area"));
        laminateAreaInput.SendKeys("10");

        IWebElement laminateDirectionButton = Driver.FindElement(By.Id("direction-laminate-id2"));
        laminateDirectionButton.Click();

        SelectElement laminateInstallationMethod = new SelectElement(Driver.FindElement(By.Id("laying_method_laminate")));
        laminateInstallationMethod.SelectByValue("2");

        IWebElement minCutLength = Driver.FindElement(By.Id("min_length_segment_id"));
        minCutLength.SendKeys(Keys.Control + "a");
        minCutLength.SendKeys(Keys.Backspace);
        minCutLength.SendKeys("200");

        IWebElement distFromWalls = Driver.FindElement(By.Id("indent_walls_id"));
        distFromWalls.SendKeys(Keys.Control + "a");
        distFromWalls.SendKeys(Keys.Backspace);
        distFromWalls.SendKeys("10");

        IWebElement calcButton = Driver.FindElement(By.Id("btn_calculate"));
        calcButton.Click();
        Thread.Sleep(3000);
        
        Assert.Multiple(() =>
        {
            IWebElement laminateCountResult =
                Driver.FindElement(By.CssSelector(".calc-result"));

            Assert.That(new Regex(@"\r|\n").Replace(laminateCountResult.Text, ""),
                Is.EqualTo(
                    "Требуемое количество плашек ламината: 49Количество упаковок ламината: 3Стоимость ламината: 0 рубВес ламината: 0 кг"));

            IWebElement areaRoomResult = Driver.FindElement(By.Id("area_room"));
            Assert.That(areaRoomResult.Text, Is.EqualTo("Площадь комнаты: 15 м2"));
        });
    }
}