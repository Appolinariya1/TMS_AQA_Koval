using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class ProductsPage : BasePage
{
    private static string END_POINT = "index.php?/dashboard";
    
    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("title");

    
    public ProductsPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }

    // Атомарные Методы
    public IWebElement TitleLabel => Driver.FindElement(TitleLabelBy);
}