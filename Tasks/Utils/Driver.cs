namespace ConsoleApp1.Utils;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

public class Driver
{
    private static IWebDriver _Driver;
    
    private Driver() { }

    public static IWebDriver GetInstance()
    {
        if (_Driver == null)
        {
            var browser = ConfigManager.ReadBrowserName();
            _Driver = DriverFactory.Build(browser);
            Logger.Instance.Info($"Browser -> ");
            _Driver.Manage().Window.Maximize();
        }

        return _Driver;
    }

    public static void Goto(string url)
    {
        Logger.Instance.Info($"Navigating to : {url}");
        GetInstance().Navigate().GoToUrl(url);
    }

    public static void Quit()
    {
        Logger.Instance.Info("Disposing web browser");
        GetInstance().Quit();
        GetInstance().Dispose();
    }
    
    public static void ScrollToElement(IWebElement element)
    {
        Actions actions = new Actions(GetInstance());
        actions.MoveToElement(element).Perform();
    }
    
    public static void TakeScreenshot()
    {   
        var ss = ((ITakesScreenshot)GetInstance()).GetScreenshot();
        var ssFileName = Path.Combine($"../../../Screenshots/");
        var now = DateTime.Now;
        var timestamp = now.ToString("yy-MM-dd hh-mm-ss").Trim().Replace(' ', '_').Replace('-', '_');

        ss.SaveAsFile($"{ssFileName}_{timestamp}.png", ScreenshotImageFormat.Png);
    }
}