namespace ConsoleApp1.TestCases;

using Utils;
using NUnit.Framework;

[TestFixture]
public class LoginTests : BaseTest
{
    [Test]
    public void LoginWithCorrectCredentialsTest()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(GmailCredentials.Password);
        PasswordPage.ClickNextButton();
        
        Assert.AreEqual(ExpectedData.Title, PasswordPage.GetTitle(), "The title is not equal to expected title");
    }
    
    [Test]
    [TestCase("gkhdsf@gmail.com")]
    public void LoginWithWrongEmailAddressTest(string email)
    {
        Driver.Goto(ConfigData.GmailUrl);

        EmailPage.EnterEmail(email);
        EmailPage.EnterEmailNextButton();

        var actualText = EmailPage.GetErrorTextForWrongAddress();
        Assert.AreEqual(ErrorData.WrongEmailAddress, actualText, "You entered correct email address!");
    }
    
    [Test]
    public void LoginWithEmptyEmailAddressTest()
    {
        Driver.Goto(ConfigData.GmailUrl);

        EmailPage.EnterEmail("");
        EmailPage.EnterEmailNextButton();
        
        var actualText = EmailPage.GetErrorTextForEmptyAddress();
        Assert.AreEqual(ErrorData.EmptyEmailAddress, actualText, "You did not enter empty email address!");
    }
    
    [Test]
    [TestCase("sdf32343")]
    public void LoginWithWrongPasswordTest(string wrongPassword)
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(wrongPassword);
        PasswordPage.ClickNextButton();

        var actualErrorText = PasswordPage.GetErrorMessage();
        Assert.AreEqual(ErrorData.WrongPassword, actualErrorText, "Please enter wrong password credentials!");
    }

    [Test]
    [TestCase("")]
    public void LoginWithEmptyPasswordTest(string password)
    {
        Driver.Goto(ConfigData.GmailUrl);

        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EnterEmailNextButton();
        
        PasswordPage.EnterPassword(password);
        PasswordPage.ClickNextButton();

        var actualErrorText = PasswordPage.GetErrorMessage();
        Assert.AreEqual( ErrorData.EmptyPassword, actualErrorText, "You did not enter empty password credentials!");
    }
}