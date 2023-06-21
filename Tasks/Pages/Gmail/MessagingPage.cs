namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;

public class MessagingPage
{
    // Declaring locators
    public By To => By.XPath("//input[contains(@class, 'aFw')]");
    
    public By Subject => By.XPath("//input[@name='subjectbox']");

    public By MessageBox = By.XPath("//div[@aria-label='Message Body']");
    
    public By SendButton = By.XPath("//div[contains(@aria-label, 'Send') and @role='button']");

    // Declaring elements
    public IWebElement ToField => Driver.GetInstance().FindElement(To);
    
    public IWebElement SubjectField => Driver.GetInstance().FindElement(Subject);
    
    public IWebElement MessageBoxField => Driver.GetInstance().FindElement(MessageBox);
    
    public IWebElement SendBtnField => Driver.GetInstance().FindElement(SendButton);
    
    // Declaring page methods
    public void EnterReceiverAddress(string emailAddress)
    {
        WaitUtils.WaitForElementVisibility(To);
        ToField.SendKeys(emailAddress);
    }

    public void EnterMessageTopic(string messageSubject) => SubjectField.SendKeys(messageSubject);
    
    public void WriteMessage(string message)
    {
        WaitUtils.WaitForElementToBeClickable(MessageBox);
        MessageBoxField.Click();
        MessageBoxField.SendKeys(message);
    }

    public void SendMessage()
    {
        WaitUtils.WaitForElementToBeClickable(SendButton);
        SendBtnField.Click();
    }
}