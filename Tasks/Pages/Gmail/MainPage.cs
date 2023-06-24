namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;

public class MainPage
{
    // Declaring locators
    public By DownArrowLocator => By.ClassName("CJ");

    public By SettingsLocator => By.XPath(" //div[contains(@class, 'Q7')]");

    public By ComposeBtnLocator => By.XPath("//div[@gh='cm']");
    
    public By ReceivedMessagesLabelLocator => By.XPath("//div[@class='Cp']//tr");

    public By ReplyBtnLocator => By.XPath("//span[contains(@class, 'bkH') and contains(text(),'Reply')]");

    public By TextAreaLocator => By.XPath("//div[@role='textbox']");
    
    public By SendBtnLocator => By.XPath("//div[@role='button' and contains(@aria-label, 'Send')]");
    
    // Declaring elements
    public IWebElement DownArrow => Driver.GetInstance().FindElement(DownArrowLocator);
    
    public IWebElement Settings => Driver.GetInstance().FindElement(SettingsLocator);

    public IWebElement ComposeButton => Driver.GetInstance().FindElement(ComposeBtnLocator);
    
    public List<IWebElement> ReceivedMessagesList =>
        Driver.GetInstance().FindElements(ReceivedMessagesLabelLocator).ToList();

    public IWebElement ReplyButton =>
        Driver.GetInstance().FindElement(ReplyBtnLocator);

    public IWebElement TextArea => Driver.GetInstance().FindElement(TextAreaLocator);
    
    public IWebElement SendButton => Driver.GetInstance().FindElement(SendBtnLocator);
    
    // Declaring page methods
    public void EnterDownArrowLink()
    {
        WaitUtils.WaitForElementVisibility(DownArrowLocator);
        DownArrow.Click();
    }
    
    public void EnterSettings()
    {
        WaitUtils.WaitForElementToBeClickable(SettingsLocator);
        Driver.ScrollToElement(Settings);
        Settings.Click();
    }

    public void ClickMessageBox()
    {
        WaitUtils.WaitForElementVisibility(ComposeBtnLocator);
        ComposeButton.Click();
    }

    public void EnterSenderMessageLabel()
    {
        WaitUtils.WaitForElementVisibility(ReceivedMessagesLabelLocator);
        ReceivedMessagesList.ElementAt(0).Click();
    }

    public void ClickReplyBtn()
    {
        WaitUtils.WaitForElementToBeClickable(ReplyBtnLocator);
        ReplyButton.Click();
    }

    public void EnterReplyMessageAndSend(string message)
    {
        WaitUtils.WaitForElementToBeClickable(TextAreaLocator);
        TextArea.Click();
        TextArea.SendKeys(message);
        WaitUtils.WaitForElementToBeClickable(SendBtnLocator);
        SendButton.Click();
    }
}