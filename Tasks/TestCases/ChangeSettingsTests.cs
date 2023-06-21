namespace ConsoleApp1.TestCases;

using Utils;
using NUnit.Framework;

[TestFixture]
public class ChangeSettingsTests : BaseTest
{
    [Test]
    public void ChangeUserNickNameTest()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EnterEmailNextButton(); 
        
        PasswordPage.EnterPassword(GmailCredentials.Password);
        PasswordPage.ClickNextButton();
        
        MainPage.EnterDownArrowLink();
        MainPage.EnterSettings();

        SettingsPage.ClickAccountLink();
        SettingsPage.ClickEditButton();
        SettingsPage.EnterNewNickAndSave(ConfigData.NewNickname);
        Thread.Sleep(2000);
        
        Assert.AreEqual(ExpectedData.NickName, SettingsPage.GetNewNick(), "Names do not match with each other");
    }
}