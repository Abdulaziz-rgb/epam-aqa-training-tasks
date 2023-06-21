namespace ConsoleApp1.Pages.Proton;

using Utils;
using OpenQA.Selenium;

public class ProtonMainPage
{
    public IWebElement UnreadMessagesLabel => Driver.GetInstance().FindElement(By.Id("zm_unread"));
    
    public IWebElement SenderMail =>
        Driver.GetInstance().FindElement(By.XPath("//span[contains(@class, 'zmLSender')]"));

    public IWebElement MessageBoxLabel => Driver.GetInstance().FindElement(By.XPath("//div[contains(@class, 'SC_mclst zmLClassic')]/child::div[1]"));
    
    public IWebElement SenderMessage =>
        Driver.GetInstance().FindElement(By.XPath("//span[contains(@class, 'zmLSub')]"));
    
    public IWebElement ReplyBtn =>
        Driver.GetInstance().FindElement(By.XPath("//span[text()='Reply']"));
    
    public IWebElement MessageComposerFrame => 
        Driver.GetInstance().FindElement(By.XPath("//iframe[@class='ze_area']"));
    //div[@class='ze']/iframe
    
    public IWebElement MessageBox => 
        Driver.GetInstance().FindElement(By.XPath("//body[@class='ze_body']/child::div[1]"));
    
    public IWebElement TextArea => 
        Driver.GetInstance().FindElement(By.XPath("//div[@id='Zm-_Id_-Sgn']//span"));
    
    public IWebElement SendButton =>
        Driver.GetInstance().FindElement(By.XPath("//div[@class='zmCRBlk']//span[text()='Send']"));

    public void ClickUnreadMessagesLabel()
    {
        WaitUtils.WaitForElementToBeClickable(By.Id("zm_unread"));
        UnreadMessagesLabel.Click();
    }
    
    public void ClickMessageLabelBox()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//div[contains(@class, 'SC_mclst zmLClassic')]/child::div[1]"));
        MessageBoxLabel.Click();
    }
    
    public string GetSenderName()
    {
        WaitUtils.WaitForElementVisibility(By.XPath("//span[contains(@class, 'zmLSender')]"));
        return SenderMail.Text.Split('@')[0];
    }
    
    public string GetMessageContent()
    {
        WaitUtils.WaitForElementVisibility(By.XPath("//span[contains(@class, 'zmLSub')]"));
        var content = SenderMessage.Text;

        return content;
    }

    public void ClickReplyBtn()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//span[text()='Reply']"));
        ReplyBtn.Click();
    }

    public void DeleteAutoMessage()
    {
        WaitUtils.WaitForElementVisibility(By.XPath("//div[@id='Zm-_Id_-Sgn']//span"));
        TextArea.Click();
        TextArea.SendKeys(Keys.Control + 'a');
        TextArea.SendKeys(Keys.Backspace);
        TextArea.SendKeys("This is a test message!!");
    }
    
    public void EnterMessage()
    {
        Driver.GetInstance().SwitchTo().Frame(MessageComposerFrame);
        
        MessageBox.SendKeys("This is a back message to server one");
        
        Driver.GetInstance().SwitchTo().DefaultContent();
    }

    public void SendMessage()
    {
        WaitUtils.WaitForElementToBeClickable(By.XPath("//div[@class='zmCRBlk']//span[text()='Send']"));
        SendButton.Click();
    }
}