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
        EmailPage.EmailNextButton.Click(); 
        
        PasswordPage.EnterPassword(GmailCredentials.Password);
        PasswordPage.PasswordNextButton.Click();
        
        MainPage.EnterDownArrowLink();
        MainPage.EnterSettings();

        SettingsPage.ClickAccountLink();
        SettingsPage.ClickEditButton();
        SettingsPage.EnterNewNickAndSave(ConfigData.NewNickname);

        Assert.AreEqual(ExpectedData.NickName, SettingsPage.GetNewNick(), "Names do not match with each other");
    }
}