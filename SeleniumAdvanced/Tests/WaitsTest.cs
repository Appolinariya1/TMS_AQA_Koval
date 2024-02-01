using OpenQA.Selenium;
using SeleniumBasic.Helpers;

namespace SeleniumBasic.Tests;

public class WaitsTest : BaseTest
{
    [Test]
    public void PresenceOfElementTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = Driver.FindElement(By.TagName("button"));
        button.Click();
        
        Assert.IsFalse(button.Displayed);

        IWebElement loading = Driver.FindElement(By.Id("loading"));
        Assert.IsTrue(loading.Displayed);
        Thread.Sleep(10000);
        Assert.IsFalse(loading.Displayed);
        
        Assert.IsTrue(Driver.FindElement(By.Id("finish")).Displayed);
    }
    
    [Test]
    public void PresenceOfElementTest1()
    {
        WaitsHelper waitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(30));
        
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = waitsHelper.WaitForVisibilityLocatedBy(By.TagName("button"));
        button.Click();
        
        Assert.IsTrue(waitsHelper.WaitForElementInvisible(By.TagName("button")));

        IWebElement loading = waitsHelper.WaitForVisibilityLocatedBy(By.Id("loading"));
        Assert.IsTrue(loading.Displayed);
        
        Assert.IsTrue(waitsHelper.WaitForElementInvisible(By.Id("loading")));
        
        Assert.IsTrue(waitsHelper.WaitForVisibilityLocatedBy(By.Id("finish")).Displayed);
    }
    
    [Test]
    public void PresenceOfElementTest2()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = WaitsHelper.FluentWaitForElement(By.TagName("button"));
        button.Click();
        
        Assert.IsTrue(WaitsHelper.WaitForElementInvisible(button));

        IWebElement loading = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("loading"));
        Assert.IsTrue(loading.Displayed);
        
        Assert.IsTrue(WaitsHelper.WaitForElementInvisible(loading));
        
        Assert.IsTrue(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("finish")).Displayed);
    }
}