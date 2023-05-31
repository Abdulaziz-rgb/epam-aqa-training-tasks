namespace ConsoleApp1.TestUtils;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

public class DriverFactory
{
    public static IWebDriver Build(string browserName)
    {
        browserName = browserName.ToLower();
        switch (browserName)
        {
            case "chrome":
                 ChromeOptions options = new ChromeOptions();
                 options.AddArgument("--lang=en");
                 options.AddArgument("--no-sandbox");
                return new ChromeDriver(options);
            case "firefox":
                return new FirefoxDriver();
            default:
                throw new NotSupportedException($"{browserName} is not supported ");
        }
    }
}