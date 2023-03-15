namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class EmailPage
{
    public IWebElement EmailField => Driver.GetInstance().FindElement(By.XPath("//input[@type='email']"));
    
    public IWebElement EmailNextButton => Driver.GetInstance().FindElement(By.XPath("//span[contains(text(), 'Next')]"));
    
    public void EnterEmail(string mail)
    {
        EmailField.Click();
        EmailField.SendKeys(mail);
    }

    public void EnterEmailNextButton()
    {
        EmailNextButton.Click();
        Thread.Sleep(2000);
    }

    public string GetErrorTextForWrongAddress()
    {
        var wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromSeconds(10));
        var errorText = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Couldn’t sign you in']"))).Text;
        return errorText;
    }

    public string GetErrorTextForEmptyAddress()
    {
        var element = Driver.GetInstance().FindElement(By.XPath("//div[contains(@class, 'o6cuMc Jj6Lae')]")).Text;
        return element;
    }
}
