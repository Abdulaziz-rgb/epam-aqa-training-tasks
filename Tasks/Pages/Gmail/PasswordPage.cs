namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;

public class PasswordPage
{
    // Declaring locators
    public By PasswordFieldLocator => By.Name("Passwd");

    public By PasswordNextBtnLocator => By.XPath("//span[contains(text(), 'Next')]");

    public By ErrorTextFieldLocator => By.XPath("//div[@jsname='B34EJ']");

    public By SearchFieldLocator => By.XPath("//form[@role='search']");
    
    // Declaring elements
    public IWebElement PasswordField => Driver.GetInstance().FindElement(PasswordFieldLocator);
    
    public IWebElement PasswordNextButton => Driver.GetInstance().FindElement(PasswordNextBtnLocator);

    public IWebElement ErrorTextField => Driver.GetInstance().FindElement(ErrorTextFieldLocator);
    
    // Declaring page methods
    public void EnterPassword(string password)
    {
        WaitUtils.WaitForElementVisibility(PasswordFieldLocator);
        PasswordField.Click();
        PasswordField.SendKeys(password);
    }

    public string GetTitle()
    {
        WaitUtils.WaitForElementToBeClickable(SearchFieldLocator);
        return Driver.GetInstance().Title;
    }

    public string GetErrorMessage()
    {
        WaitUtils.WaitForElementVisibility(ErrorTextFieldLocator);
        return ErrorTextField.Text;
    }
}