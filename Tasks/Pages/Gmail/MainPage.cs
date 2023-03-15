namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;

public class MainPage
{
    private IWebElement DownArrow => Driver.GetInstance().FindElement(By.ClassName("CJ"));
    
    private IWebElement Settings => Driver.GetInstance().FindElement(By.CssSelector(".CL.Q7"));
    
    
    private IWebElement ComposeButton => Driver.GetInstance().FindElement(By.XPath("//div[@gh='cm']"));


     public void EnterDownArrowLink()
    {
        WaitUtils.WaitForElementVisibility(By.ClassName("CJ"));
        DownArrow.Click();
    }
    public void EnterSettings()
    {
        WaitUtils.WaitForElementToBeClickable(By.CssSelector(".CL.Q7"));
        Driver.ScrollToElement(Settings);
        Settings.Click();
    }

    public void ClickMessageBox()
    {
        WaitUtils.WaitForElementVisibility(By.XPath("//div[@gh='cm']"));
        ComposeButton.Click();
    }
}