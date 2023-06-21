namespace ConsoleApp1;

using Utils;
using Models;
using Pages.Gmail;
using Pages.Proton;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

public abstract class BaseTest
{
    public static EmailPage EmailPage;

    public static PasswordPage PasswordPage;

    public static MainPage MainPage;

    public static SettingsPage SettingsPage;

    public static MessagingPage MessagingPage;

    public static LoginPage LoginPage;

    public static ProtonMainPage ProtonMainPage;

    public static List<UserDataModel> UserData;

    public static ErrorDataModel ErrorData;

    public static UserDataModel GmailCredentials;

    public static UserDataModel ProtonCredentials;

    public static ConfigDataModel ConfigData;

    public static ExpectedDataModel ExpectedData;

    [OneTimeSetUp]
    public void BeforeAll()
    {
        UserData = ConfigManager.SetUserData();
        GmailCredentials = UserData[0];
        ProtonCredentials = UserData[1];
    }
    
    [SetUp]
    public void BeforeEach()
    {
        ErrorData = ConfigManager.SetErrorData();
        ConfigData = ConfigManager.SetConfigData();
        ExpectedData = ConfigManager.SetExpectedData();
        
        // Gmail Pages
        EmailPage = new EmailPage();
        PasswordPage = new PasswordPage();
        MainPage = new MainPage();
        SettingsPage = new SettingsPage();
        MessagingPage = new MessagingPage();
        
        // Zoho Pages
        LoginPage = new LoginPage();
        ProtonMainPage = new ProtonMainPage();
    }

    [TearDown]
    public void AfterEach()
    {
        var outcome = TestContext.CurrentContext.Result.Outcome.Status;
        if (outcome == TestStatus.Passed)
        {
            Logger.Instance.Info("Outcome: Passed!");
        }
        else if(outcome == TestStatus.Failed)
        {
            Driver.TakeScreenshot();
            Logger.Instance.Info("Test failed");
        }
        else
        {
            Logger.Instance.Warn("Outcome: " + outcome);
        }
        
        Driver.Quit();
    }
}