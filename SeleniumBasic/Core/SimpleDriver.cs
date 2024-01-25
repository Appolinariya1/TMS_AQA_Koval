using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.Core;

public class SimpleDriver
{
    public IWebDriver Driver
    {
        get
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            
            //return new ChromeDriver(@"E:\Rider\TMS_AQA_Koval\SeleniumBasic\Resources\"); - простой, но неправильный способ
            //return new ChromeDriver(path + @"\Resources\");
            return new ChromeDriver(basePath + @"\Resources\");
        }
    }
}