using OpenQA.Selenium;
using SeleniumBasic.Helpers.Configuration;

namespace HW_Selenium_Locators.Tests;

public class SauceDemoLocatorsTest : BaseTest
{
    [Test]
    public void BasicLocatorsTest()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        Driver.FindElement(By.Id("user-name")).SendKeys(Configurator.AppSettings.Username);
        Driver.FindElement(By.Name("password")).SendKeys(Configurator.AppSettings.Password);
        Driver.FindElement(By.ClassName("login_credentials"));
        Driver.FindElement(By.TagName("form")).Submit();
        Driver.FindElement(By.LinkText("Sauce Labs Bolt T-Shirt"));
        Driver.FindElement(By.PartialLinkText("Bike"));
    }

    [Test]
    public void XPathTest()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        //Поиск по атрибуту
        Driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys("standard_user");

        //Поиск по тексту
        Driver.FindElement(By.XPath("//div[text()='standard_user']"));

        //Поиск по частичному совпадению атрибута
        Driver.FindElement(By.XPath("//input[contains(@data-test,'passw')]")).SendKeys("secret_sauce");

        //Поиск по частичному совпадению текста
        Driver.FindElement(By.XPath("//h4[contains(text(),'Password for')]"));

        //ancestor
        Driver.FindElement(By.XPath("//*[text()='visual_user']//ancestor::div"));

        //descendant
        Driver.FindElement(
            By.XPath("//div[@class='login-box']//descendant::div[@class='error-message-container']"));

        //following
        Driver.FindElement(
            By.XPath("//div[@class='error-message-container']//following::input[@id='login-button']")).Click();

        //parent
        Driver.FindElement(By.XPath("//img[@class='inventory_item_img']//parent::a[@id='item_0_img_link']")).Click();

        //preceding
        Driver.FindElement(
            By.XPath("//div[@class='inventory_details_price']//preceding::div[text()='Sauce Labs Bike Light']"));

        //поиск элемента с условием AND
        Driver.FindElement(By.XPath("//button[@data-test='back-to-products' and @id='back-to-products']")).Click();
    }

    [Test]
    public void CssTest()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        //.class
        Driver.FindElement(By.CssSelector(".login-box"));

        //.class1.class2
        Driver.FindElement(By.CssSelector(".input_error.form_input"));

        //.class1 .class2
        Driver.FindElement(By.CssSelector(".login-box .form_group"));

        //#id
        Driver.FindElement(By.CssSelector("#user-name")).SendKeys("standard_user");

        //tagname
        Driver.FindElement(By.CssSelector("form"));

        //tagname.class
        Driver.FindElement(By.CssSelector("div.login_credentials"));

        //[attribute=value]
        Driver.FindElement(By.CssSelector("[data-test=password]")).SendKeys("secret_sauce");

        //[attribute~=value]
        Driver.FindElement(By.CssSelector("[name~='login-button']")).Click();

        //[attribute|=value]
        Driver.FindElement(By.CssSelector("[data-test|=add-to-cart-sauce-labs-fleece]")).Click();

        //[attribute^=value]
        Driver.FindElement(By.CssSelector("[data-test^=pro]"));

        //[attribute$=value]
        Driver.FindElement(By.CssSelector("[id$=jacket]")).Click();

        //[attribute*=value]
        Driver.FindElement(By.CssSelector("[id*=_3_img]")).Click();
    }
}