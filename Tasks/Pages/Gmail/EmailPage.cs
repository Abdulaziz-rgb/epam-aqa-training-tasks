namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class EmailPage
{
    // Declaring locators
    public By EmailFieldLocator => By.XPath("//input[@type='email']");
    
    public By EmailNextBtnLocator => By.XPath("//div[contains(@id, 'Next')]");
    
    public By WrongAddressErrorTextLocator => By.XPath("//span[text()='Couldn’t sign you in']");
    
    public By EmptyAddressErrorTextLocator => By.XPath("//div[contains(@class, 'Jj6Lae')]");
    
    // Declaring elements
    public IWebElement EmailInputField => Driver.GetInstance().FindElement(EmailFieldLocator);
    
    public IWebElement EmailNextButton => Driver.GetInstance().FindElement(EmailNextBtnLocator);

    public IWebElement WrongAddressErrorTextField => Driver.GetInstance().FindElement(WrongAddressErrorTextLocator);
    
    public IWebElement EmptyAddressErrorTextField => Driver.GetInstance().FindElement(EmptyAddressErrorTextLocator);
   
    // Declaring page methods
    public void EnterEmail(string mail)
    {
        EmailInputField.Click();
        EmailInputField.SendKeys(mail);
    }

    public string GetErrorTextForWrongAddress()
    {
        WaitUtils.WaitForElementVisibility(WrongAddressErrorTextLocator);
        return WrongAddressErrorTextField.Text;  
    }

    public string GetErrorTextForEmptyAddress()
    {
        WaitUtils.WaitForElementVisibility(EmptyAddressErrorTextLocator);
        return EmptyAddressErrorTextField.Text;
    }
}
