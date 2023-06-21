namespace ConsoleApp1.Pages.Proton;

using Utils;
using OpenQA.Selenium;

public class LoginPage
{
    public IWebElement SignInLink => Driver.GetInstance().FindElement(By.ClassName("zlogin-apps"));
    public IWebElement EmailField => Driver.GetInstance().FindElement(By.Id("login_id"));
    public IWebElement PasswordField => Driver.GetInstance().FindElement(By.Id("password"));
    public IWebElement SignInButton => Driver.GetInstance().FindElement(By.XPath("//button/span[text()='Sign in']"));
    
    public void ClickSignInLink()
    {
        SignInLink.Click();
    }
    public void EnterEmail(string email)
    {
        var nextBtn = Driver.GetInstance().FindElement(By.XPath("//button/span[text()='Next']"));
        
        WaitUtils.WaitForElementVisibility(By.Id("login_id"));
        EmailField.Clear();
        EmailField.SendKeys(email);
        nextBtn.Click();
    }

    public void EnterPassword(string password)
    {
        WaitUtils.WaitForElementVisibility(By.Id("password"));
        PasswordField.SendKeys(password);
    }

    public void ClickSignInButton()
    {
        SignInButton.Click();
    }
}