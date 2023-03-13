namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;

public class MessagingPage
{
    public By To => By.CssSelector("input.agP.aFw");

    public By Subject => By.CssSelector("input[name=subjectbox]");

    public By MessageBox = By.CssSelector(".Am.Al.editable.LW-avf.tS-tW");
    
    public By SendButton = By.CssSelector("div.dC div[role=button]");


    public void EnterReceiverAddress()
    {
        WaitUtils.WaitForElementVisibility(By.CssSelector("input.agP.aFw"));
        var toField = Driver.GetInstance().FindElement(To);
        toField.SendKeys("sfksm2022@proton.me");
    }

    public void EnterMessageTopic()
    {
        var subjectField = Driver.GetInstance().FindElement(Subject);
        subjectField.SendKeys("Test Scenario 2 Case");
    }
    public void WriteMessage(string message)
    {
        WaitUtils.WaitForElementToBeClickable(MessageBox);
        var messageBox = Driver.GetInstance().FindElement(MessageBox);
        messageBox.Click();
        messageBox.SendKeys(message);
    }

    public void SendMessage()
    {
        WaitUtils.WaitForElementToBeClickable(SendButton);
        var sendButton = Driver.GetInstance().FindElements(SendButton)[0];
        sendButton.Click();
    }
}