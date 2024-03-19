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

        //кликнуть правой кнопкой
        var actions = new Actions(Driver);
        actions
            .ContextClick(Driver.FindElement(By.Id("hot-spot")))
            .Build()
            .Perform();

        //обработать алерт
        IAlert alert = Driver.SwitchTo().Alert();
        Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
        alert.Accept();
    }

    [Test]
    [Description("Dynamic Controls")]
    public void DynamicControlsTest()
    {
        //перейти на страницу Dynamic Controls со стартовой страницы
        WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("Dynamic Controls")).Click();

        //Нажать на кнопку Remove около чекбокса
        Driver.FindElement(By.XPath("//button[text()='Remove']")).Click();

        //Дождаться надписи “It’s gone” и проверить, что чекбокса нет
        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));
            Assert.That(WaitsHelper.WaitForElementInvisible(By.Id("checkbox")));
        });

        //Найти инпут
        IWebElement input = Driver.FindElement(By.XPath("//input[@type='text']"));

        //Проверить, что инпут disabled
        Assert.That(!input.Enabled);

        //Нажать на кнопку Enable
        Driver.FindElement(By.XPath("//button[text()='Enable']")).Click();

        //Дождаться надписи “It's enabled!” и Проверить, что инпут enabled
        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));
            Assert.That(input.Enabled);
        });
    }
}