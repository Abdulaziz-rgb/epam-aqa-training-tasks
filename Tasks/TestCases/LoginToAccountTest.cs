using ConsoleApp1.TestBases;
using ConsoleApp1.TestUtils;

namespace ConsoleApp1.TestCases;

using Pages.Gmail;
using NUnit.Framework;


[TestFixture]
public class LoginToAccountTest : BaseTest
{
    [Test]
    public void LoginWithCorrectCredentials_Test()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(GmailCredentials.Password);
        PasswordPage.EnterPasswordNextButton();
        
        Thread.Sleep(2000);
        Assert.AreEqual(ExpectedData.Title, PasswordPage.GetTitle(), "The title is not equal to expected title");
    }
    
    [Test]
    [TestCase("gkhdsf@gmail.com")]
    public void LoginWithWrongEmailAddress_Test(string email)
    {
        Driver.Goto(ConfigData.GmailUrl);
        var expectedText = ErrorData.WrongEmailAddress;
        
        EmailPage.EnterEmail(email);
        EmailPage.EnterEmailNextButton();

        var actualText = EmailPage.GetErrorTextForWrongAddress();
        Assert.AreEqual(expectedText, actualText, "You entered correct email address!");
    }
    
    [Test]
    public void LoginWithEmptyEmailAddress_Test()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        var email = "";
        var expectedText = ErrorData.EmptyEmailAddress;
        
        EmailPage.EnterEmail(email);
        EmailPage.EnterEmailNextButton();
        
        var actualText = EmailPage.GetErrorTextForEmptyAddress();
        Assert.AreEqual(expectedText, actualText, "You did not enter empty email address!");
    }
    
    [Test]
    [TestCase("sdf32343")]
    public void LoginWithWrongPassword_Test(string wrongPassword)
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        Logger.Instance.Info($"Just a test run for url -> {ConfigData.GmailUrl}");
        var email = GmailCredentials.Mail;
        var expectedErrorText = ErrorData.WrongPassword;
        
        EmailPage.EnterEmail(email);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(wrongPassword);
        PasswordPage.EnterPasswordNextButton();

        var actualErrorText = PasswordPage.GetErrorText();
        Assert.AreEqual(expectedErrorText, actualErrorText, "Please enter wrong password credentials!");
    }

    [Test]
    [TestCase("")]
    public void LoginWithEmptyPassword_Test(string password)
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        Logger.Instance.Info($"Second log example -> {GmailCredentials.Mail}");
        var email = GmailCredentials.Mail;
        var expectedErrorText = ErrorData.EmptyPassword;
        
        EmailPage.EnterEmail(email);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(password);
        PasswordPage.EnterPasswordNextButton();

        var actualErrorText = PasswordPage.GetErrorText();
        Assert.AreEqual(expectedErrorText, actualErrorText, "You did not enter emoty password credentials!");
    }
}