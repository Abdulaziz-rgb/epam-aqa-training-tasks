namespace ConsoleApp1.Utils;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

public class Driver
{
    private static IWebDriver _driver;
    
    private Driver()
    {
    }

    public static IWebDriver GetInstance()
    {
        if (_driver == null)
        {
            _driver = DriverFactory.Build(ConfigManager._configData.Browser);
            _driver.Manage().Window.Maximize();
        }

        return _driver;
    }

    public static void Goto(string url)
    {
        GetInstance().Navigate().GoToUrl(url);
    }
    
    public static void Quit()
    {
        GetInstance().Quit();
        GetInstance().Dispose();
    }
    
    public static void ScrollToElement(IWebElement element)
    {
        //var element = GetInstance().FindElement(uniqueLocator);
        // GetInstance().ExecuteJavaScript("arguments[0].click();", element);
        Actions actions = new Actions(GetInstance());
        actions.MoveToElement(element).Perform();
    }
}