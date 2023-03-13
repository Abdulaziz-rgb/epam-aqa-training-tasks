namespace ConsoleApp1.TestCases;

using Utils;
using NUnit.Framework;

[TestFixture]
public class SendMessageTest : BaseTest
{
    [Test]
    public void SendMessageToAccount_Test()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        var mail = GmailCredentials.Mail;
        var password = GmailCredentials.Password;
        var message = ConfigData.MessageFromGmail;
        
        EmailPage.EnterEmail(mail);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(password);
        PasswordPage.EnterPasswordNextButton();
            
        MainPage.ClickMessageBox();
        
        MessagingPage.EnterReceiverAddress();
        MessagingPage.EnterMessageTopic();
        MessagingPage.WriteMessage(message);
        Thread.Sleep(1000);
        MessagingPage.SendMessage();
    }

    [Test]
    public void CheckMessageSender()
    {
        Driver.Goto(ConfigData.ProtonUrl);

        var email = ProtonCredentials.Mail;
        var password = ProtonCredentials.Password;
        var message = ConfigData.MessageFromProton;

        Thread.Sleep(3000);

        LoginPage.EnterEmail(email);
        LoginPage.EnterPassword(password);
        LoginPage.ClickSignIn();
        
        ProtonMainPage.ClickUnreadMessageCategory();
        ProtonMainPage.RefreshPage();
        
        var senderName = ProtonMainPage.GetSenderName();
        Assert.AreEqual(ExpectedData.SenderName, senderName);
        
        ProtonMainPage.ClickMessageLabel();
        
        var messageContent = ProtonMainPage.GetMessageContent();
        
        Assert.AreEqual(ExpectedData.Message, messageContent);
        
        ProtonMainPage.ClickReplyBtn();
        ProtonMainPage.EnterMessage(message);
        ProtonMainPage.SendMessage();
    }
}