namespace ConsoleApp1.TestCases;

using Utils;
using NUnit.Framework;

[TestFixture]
public class MessagingTests : BaseTest
{
    [Test]
    public void SendMessageToSecondAccountTest()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(GmailCredentials.Password);
        PasswordPage.ClickNextButton();
            
        MainPage.ClickMessageBox();
        
        MessagingPage.EnterReceiverAddress(ProtonCredentials.Mail);
        MessagingPage.EnterMessageTopic(ConfigData.MessageSubjectFromGmail);
        
        MessagingPage.WriteMessage(ConfigData.MessageFromGmail);
        MessagingPage.SendMessage();
    }

    [Test]
    public void ReadMessageAndReplyBackToFirstAccountTest()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(ProtonCredentials.Mail);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(ProtonCredentials.Password);
        PasswordPage.ClickNextButton();
        
        MainPage.EnterSenderMessageLabel();
        MainPage.ClickReplyBtn();
        
        MainPage.EnterReplyMessageAndSend(ConfigData.MessageFromProton);
    }
}