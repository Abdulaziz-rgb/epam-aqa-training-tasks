namespace ConsoleApp1.Pages.Proton;

using Utils;
using OpenQA.Selenium;

public class ProtonMainPage
{
    public IWebElement UnreadMessagesBtn => 
        Driver.GetInstance().FindElement(By.XPath("//div/button[contains(@data-testid, 'unread')]"));

    public IWebElement RefreshButton => 
        Driver.GetInstance().FindElement(By.XPath("//*[local-name()='svg' and contains(@data-testid,'refresh')]"));

    public string SenderName =>
        Driver.GetInstance().FindElement(By.XPath("//span[contains(@data-testid, 'sender')]")).Text;

    public IWebElement TargetMessageLabel => 
        Driver.GetInstance().FindElement(By.XPath("//div[contains(@class, 'unread')]"));

    public IWebElement MessageContentFrame =>
        Driver.GetInstance().FindElement(By.XPath("//iframe[@data-testid='content-iframe']"));
    
    public IWebElement MessageContent => 
        Driver.GetInstance().FindElement(By.XPath("//div[@dir='ltr']"));

    public IWebElement ReplyBtn =>
        Driver.GetInstance().FindElement(By.XPath("//button[contains(@data-testid, 'reply')]"));
    
    public IWebElement MessageComposerFrame => 
        Driver.GetInstance().FindElement(By.XPath("//iframe[@title='Email composer']"));
    
    public IWebElement MessageBox => 
        Driver.GetInstance().FindElement(By.XPath("//div[@id='rooster-editor']"));
    
    public IWebElement SendMessageBtn =>
        Driver.GetInstance().FindElement(By.XPath("//button[contains(@class, 'send-button')]"));
    
    
    public void ClickUnreadMessageCategory()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//div/button[contains(@data-testid, 'unread')]"));
        UnreadMessagesBtn.Click();
    }

    public void RefreshPage()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//*[local-name()='svg' and contains(@data-testid,'refresh')]"));
        RefreshButton.Click();
    }

    public string GetSenderName()
    {
        WaitUtils.WaitForElementVisibility(By.XPath("//span[contains(@data-testid, 'sender')]"));
        return SenderName;
    }

    public void ClickMessageLabel()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//div[contains(@class, 'unread')]"));
       TargetMessageLabel.Click(); 
    }

    public string GetMessageContent()
    {
        WaitUtils.WaitForElementVisibility(By.XPath("//iframe[@data-testid='content-iframe']"));
        Driver.GetInstance().SwitchTo().Frame(MessageContentFrame);
        var content = MessageContent.Text;
        Driver.GetInstance().SwitchTo().DefaultContent();
        
        return content;
    }

    public void ClickReplyBtn()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//button[contains(@data-testid, 'reply')]"));
        ReplyBtn.Click();
    }

    public void EnterMessage(string message)
    {
        Driver.GetInstance().SwitchTo().Frame(MessageComposerFrame);
        
        MessageBox.Clear();
        MessageBox.SendKeys("This is a back message to server one");
        
        Driver.GetInstance().SwitchTo().ParentFrame();
    }

    public void SendMessage()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//button[contains(@class, 'send-button')]"));
        SendMessageBtn.Click();
    }
}