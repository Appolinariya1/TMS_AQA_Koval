using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class LoginPage : BasePage
{
    // Описание элементов
    private static readonly By EmailInputBy = By.Id("name");
    
    
    // Инициализация класса + переопределения
    public LoginPage(IWebDriver driver) : base(driver)
    {
    }
    
    // Атомарные Методы
    public IWebElement EmailInput => Driver.FindElement(EmailInputBy);
}