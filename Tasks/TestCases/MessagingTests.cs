namespace ConsoleApp1.TestCases;

using Utils;
using NUnit.Framework;

[TestFixture]
public class MessagingTests : BaseTest
{
    [Test]
    // [Category("AllRegression")]
    [Parallelizable(ParallelScope.Self)]
    public void SendMessageToSecondAccountTest()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EmailNextButton.Click();
        
        PasswordPage.EnterPassword(GmailCredentials.Password);
        PasswordPage.PasswordNextButton.Click();
            
        MainPage.ClickMessageBox();
        
        MessagingPage.EnterReceiverAddress(ProtonCredentials.Mail);
        MessagingPage.EnterMessageTopic(ConfigData.MessageSubjectFromGmail);
        
        MessagingPage.WriteMessage(ConfigData.MessageFromGmail);
        MessagingPage.SendMessage();
    }

    [Test]
    // [Category("AllRegression")]
    [Parallelizable(ParallelScope.Self)]
    public void ReadMessageAndReplyBackToFirstAccountTest()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(ProtonCredentials.Mail);
        EmailPage.EmailNextButton.Click();
        
        PasswordPage.EnterPassword(ProtonCredentials.Password);
        PasswordPage.PasswordNextButton.Click();
        
        MainPage.EnterSenderMessageLabel();
        MainPage.ClickReplyBtn();
        
        MainPage.EnterReplyMessageAndSend(ConfigData.MessageFromProton);
    }
}