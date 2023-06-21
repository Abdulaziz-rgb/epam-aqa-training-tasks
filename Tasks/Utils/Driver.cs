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
            _Driver = DriverFactory.Build(ConfigManager._configData.Browser);
            _Driver.Manage().Window.Maximize();
        }

        return _Driver;
    }

    public static void Goto(string url) => GetInstance().Navigate().GoToUrl(url);

    public static void Quit()
    {
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
        var ssFileName = Path.Combine($"../../../Screenshot/");
        var timestamp = DateTime.Now.ToString("yy-MM-dd hh-mm-ss").Trim().Replace(' ', '_').Replace('-', '_');

        ss.SaveAsFile($"{ssFileName}_{timestamp}.png", ScreenshotImageFormat.Png);
    }
}