using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HomeWorkSeleniumAdvanced.Tests;

public class HomeWorkTests : BaseTest
{
    [Test]
    [Description("Context Menu")]
    public void ContextMenuTest()
    {
        //перейти на страницу Context Menu со стартовой страницы
        WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("Context Menu")).Click();

        //клик правой кнопкой
        var actions = new Actions(Driver);
        actions
            .ContextClick(Driver.FindElement(By.Id("hot-spot")))
            .Build()
            .Perform();

        //обработка алерта
        IAlert alert = Driver.SwitchTo().Alert();
        Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
        alert.Accept();
    }
}