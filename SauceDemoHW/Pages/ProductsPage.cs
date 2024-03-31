using OpenQA.Selenium;

namespace SauceDemoHW.Pages;

public class ProductsPage : BasePage
{
    private static string END_POINT = "inventory.html";

    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("title");
    private static readonly By ProductBackpackBy = By.ClassName("inventory_item_name");
    private static readonly By AddToCartButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
    private static readonly By RemoveFromCartButtonBy = By.Id("remove-sauce-labs-backpack");
    private static readonly By ShoppingCartBadgeBy = By.ClassName("shopping_cart_badge");
    private static readonly By ShoppingCartLinkBy = By.ClassName("shopping_cart_link");

    public ProductsPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("Products");
    }

    // Методы
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    public IWebElement ProductBackpack => WaitsHelper.WaitForExists(ProductBackpackBy);
    public IWebElement AddPackpackButton => WaitsHelper.WaitForExists(AddToCartButtonBy);
    public IWebElement RemoveBackpackButton => WaitsHelper.WaitForExists(RemoveFromCartButtonBy);
    public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);
    public IWebElement ShoppingCartLink => WaitsHelper.WaitForExists(ShoppingCartLinkBy);

    public void AddProduct() => AddPackpackButton.Click();
    public void RemoveProduct() => RemoveBackpackButton.Click();

    public CartPage ClickShoppingCartLink()
    {
        ShoppingCartLink.Click();
        return new CartPage(Driver, true);
    }
}