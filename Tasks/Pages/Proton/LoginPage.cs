namespace ConsoleApp1.Pages.Proton;

using Utils;
using OpenQA.Selenium;

public class LoginPage
{
    public IWebElement EmailField => Driver.GetInstance().FindElement(By.Id("username"));

    public IWebElement PasswordField => Driver.GetInstance().FindElement(By.Id("password"));

    public IWebElement SignInButton => Driver.GetInstance().FindElement(By.XPath("//button[@type='submit']"));

    public void EnterEmail(string email)
    {
        WaitUtils.WaitForElementVisibility(By.Id("username"));
        EmailField.SendKeys(email);
    }

    public void EnterPassword(string password)
    {
        WaitUtils.WaitForElementVisibility(By.Id("password"));
        PasswordField.SendKeys(password);
    }

    public void ClickSignIn()
    {
        SignInButton.Click();
    }
}