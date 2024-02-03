using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumBasic.Tests;

public class ActionsTest : BaseTest
{
    [Test]
    public void HoversTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");

        var targetElements = WaitsHelper.WaitForAllVisibleElementsLocatedBy(By.CssSelector(".figure"));

        var actions = new Actions(Driver);

        actions
            .MoveToElement(targetElements[0], 20, 20)
            .Click(WaitsHelper.WaitForExists(By.CssSelector("[href='/users/1']")))
            .Build()
            .Perform();

        Assert.Multiple(() =>
            {
                Assert.That(WaitsHelper.WaitForElementInvisible(targetElements[0]));
                Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.TagName("h1")).Text, Is.EqualTo("Not Found"));
            }
        );
    }

    [Test]
    public void DragAndDropTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");

        var actions = new Actions(Driver);

        var targetElementA = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-a"));
        var targetElementB = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-b"));

        actions
            .DragAndDrop(targetElementA, targetElementB)
            .Build()
            .Perform();
    }

    [Test]
    public void FileUploadTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

        var fileUploadElement = WaitsHelper.WaitForExists(By.Id("file-upload"));

        // Получаем путь к исполняемому файлу (exe)
        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // Конструируем путь к файлу внутри проекта
        string filePath = Path.Combine(assemblyPath, "Resources", "download.jpeg");
        Console.WriteLine(filePath);

        fileUploadElement.SendKeys(filePath);

        WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
        Thread.Sleep(5000);
    }
}