namespace ConsoleApp1.Utils;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public static class WaitUtils
{
    public static WebDriverWait Wait = new(Driver.GetInstance(), TimeSpan.FromSeconds(40));

    static WaitUtils() { }
    
    public static void WaitForElementVisibility(By uniqueLocator) => 
        Wait.Until(ExpectedConditions.ElementIsVisible(uniqueLocator));

    public static void WaitForElementToBeClickable(By uniqueLocator) => 
        Wait.Until(ExpectedConditions.ElementToBeClickable(uniqueLocator));
}