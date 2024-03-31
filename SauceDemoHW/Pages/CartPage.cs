using OpenQA.Selenium;

namespace SauceDemoHW.Pages;

public class CartPage : BasePage
{
    private static string END_POINT = "cart.html";

    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("title");
    private readonly By ProductLabelBy = By.ClassName("inventory_item_name");
    private readonly By RemoveButtonBy = By.Id("remove-sauce-labs-backpack");
    private readonly By ShoppingCartBadgeBy = By.ClassName("shopping_cart_badge");
    private readonly By CheckoutButtonBy = By.Id("checkout");
    private readonly By ContinueShoppingButtonBy = By.Id("continue-shopping");

    public CartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("Your Cart");
    }

    // Методы
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    public IWebElement ProductLabel => WaitsHelper.WaitForExists(ProductLabelBy);
    public bool ProductLabelInvisibility => WaitsHelper.WaitForElementInvisible(ProductLabelBy);
    public bool ShoppingCartBadgeInvisibility => WaitsHelper.WaitForElementInvisible(ShoppingCartBadgeBy);
    public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
    public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
    public IWebElement ContinueShoppingButton => WaitsHelper.WaitForExists(ContinueShoppingButtonBy);

    public void ClickRemoveButton() => RemoveButton.Click();

    public CheckoutInfoPage ClickCheckoutButton()
    {
        CheckoutButton.Click();
        return new CheckoutInfoPage(Driver, true);
    }

    public ProductsPage ClickContinueShoppingButton()
    {
        CheckoutButton.Click();
        return new ProductsPage(Driver, true);
    }
}