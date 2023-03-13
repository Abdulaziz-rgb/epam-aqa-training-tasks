namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;

public class PasswordPage
{
    public IWebElement PasswordField => Driver.GetInstance().FindElement(By.Name("Passwd"));
    
    public IWebElement PasswordNextButton => Driver.GetInstance().FindElement(By.XPath("//span[contains(text(), 'Next')]"));

    public void EnterPassword(string password)
    {
        WaitUtils.WaitForElementVisibility(By.Name("Passwd"));
        PasswordField.Click();
        PasswordField.SendKeys(password);
    }

    public void EnterPasswordNextButton()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//span[contains(text(), 'Next')]"));
        PasswordNextButton.Click();
    }

    public static string GetTitle()
    {
        var title = Driver.GetInstance().Title.Split(" - ")[2];
        return title;
    }

    public string GetErrorText()
    {
        WaitUtils.WaitForElementVisibility(By.XPath("//div[@jsname='B34EJ']"));
        var errorText = Driver.GetInstance().FindElement(By.XPath("//div[@jsname='B34EJ']")).Text;
        
        return errorText;
    }
}