using OpenQA.Selenium;

namespace SeleniumBasic.Tests;

public class CssSelectorTest : BaseTest
{
    [Test]
    public void CssSelectorsTest()
    {
        Driver.Navigate().GoToUrl("file:E:\\Rider\\TMS_AQA_Koval\\Locators\\Resources\\index.html");
        Thread.Sleep(2000);
        
        //Поиск по id
        Assert.That(Driver.FindElement(By.CssSelector("#my-Address")).Displayed);
        
        // Поиск по class name
        Assert.That(Driver.FindElement(By.CssSelector(".newsletter")).Displayed);
        
        // Поиск по нескольким значениям в атрибуте class
        Assert.That(Driver.FindElement(By.CssSelector(".noSel.newsletter")).Displayed);

        // Поиск по tag name
        Assert.That(Driver.FindElement(By.CssSelector("h1")).Displayed);

        // Поиск по tag и значению из атрибута class
        Assert.That(Driver.FindElement(By.CssSelector("div.intro")).Displayed);

        // Поиск по tag и значению из атрибута class
        Assert.That(Driver.FindElements(By.CssSelector("span .markup")).Count, Is.EqualTo(4));
        
        // Поиск всех элементов с тэгом h1 или p
        Assert.That(Driver.FindElements(By.CssSelector("h1, p")).Count, Is.EqualTo(8));
        
        // Поиск всех элементов с тэгом p у которых непосредственный родитель с тэгом div
        Assert.That(Driver.FindElements(By.CssSelector("div > p")).Count, Is.EqualTo(6));
    }
}