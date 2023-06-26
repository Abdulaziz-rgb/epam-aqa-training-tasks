namespace ConsoleApp1.TestCases;

using Utils;
using NUnit.Framework;

[TestFixture]
public class LoginTests : BaseTest
{
    [Test]
    [Category("LoginWithCorrectCredentials")]
    public void LoginWithCorrectCredentialsTest()
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EmailNextButton.Click();
        
        PasswordPage.EnterPassword(GmailCredentials.Password);
        PasswordPage.PasswordNextButton.Click();
        
        Assert.AreEqual(ExpectedData.Title, PasswordPage.GetTitle(), "The title is not equal to expected title");
    }
    
    [Test]
    [TestCase("gkhdsf@gmail.com")]
    [Category("LoginWithWrongEmailAddress")]
    public void LoginWithWrongEmailAddressTest(string email)
    {
        Driver.Goto(ConfigData.GmailUrl);

        EmailPage.EnterEmail(email);
        EmailPage.EmailNextButton.Click();

        var actualText = EmailPage.GetErrorTextForWrongAddress();
        Assert.AreEqual(ErrorData.WrongEmailAddress, actualText, "You entered correct email address!");
    }
    
    [Test]
    [Category("LoginWithEmptyEmailAddress")]
    public void LoginWithEmptyEmailAddressTest()
    {
        Driver.Goto(ConfigData.GmailUrl);

        EmailPage.EnterEmail(String.Empty);
        EmailPage.EmailNextButton.Click();
        
        var actualText = EmailPage.GetErrorTextForEmptyAddress();
        Assert.AreEqual(ErrorData.EmptyEmailAddress, actualText, "You did not enter empty email address!");
    }
    
    [Test]
    [TestCase("sdf32343")]
    [Category("LoginWithWrongPassword")]
    public void LoginWithWrongPasswordTest(string wrongPassword)
    {
        Driver.Goto(ConfigData.GmailUrl);
        
        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EmailNextButton.Click();
        
        PasswordPage.EnterPassword(wrongPassword);
        PasswordPage.PasswordNextButton.Click();
        
        var actualErrorText = PasswordPage.GetErrorMessage();
        Assert.AreEqual(ErrorData.WrongPassword, actualErrorText, "Please enter wrong password credentials!");
    }

    [Test]
    [Category("LoginWithEmptyPassword")]
    public void LoginWithEmptyPasswordTest( )
    {
        Driver.Goto(ConfigData.GmailUrl);

        EmailPage.EnterEmail(GmailCredentials.Mail);
        EmailPage.EmailNextButton.Click();
        
        PasswordPage.EnterPassword(string.Empty);
        PasswordPage.PasswordNextButton.Click();

        var actualErrorText = PasswordPage.GetErrorMessage();
        Assert.AreEqual( ErrorData.EmptyPassword, actualErrorText, "You did not enter empty password credentials!");
    }
}