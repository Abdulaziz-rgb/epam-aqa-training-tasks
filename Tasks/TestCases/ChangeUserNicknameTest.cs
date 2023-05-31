using ConsoleApp1.TestBases;
using ConsoleApp1.TestUtils;

namespace ConsoleApp1.TestCases;

using NUnit.Framework;

[TestFixture]
public class ChangeUserNicknameTest : BaseTest
{
    [Test]
    public void ChangeUserNickName_Test()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        var mail = GmailCredentials.Mail;
        var password = GmailCredentials.Password;
        var newNickname = ConfigData.NewNickname;

        EmailPage.EnterEmail(mail);
        EmailPage.EnterEmailNextButton(); 
        
        PasswordPage.EnterPassword(password);
        PasswordPage.EnterPasswordNextButton();
        
        MainPage.EnterDownArrowLink();
        MainPage.EnterSettings();

        SettingsPage.ClickAccountLink();
        SettingsPage.ClickEditButton();
        SettingsPage.EnterNewNick(newNickname);
        Thread.Sleep(2000);
        
        Assert.AreEqual(ExpectedData.NickName, SettingsPage.GetNewNick(), "Names do not match with each other");
    }
}