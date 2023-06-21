namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;

public class SettingsPage
{
    // Declaring locators
    public By AccountsLinkLocator => By.XPath("//div[@class='f1']/a[contains(@href,'accounts')]");

    public By EditButtonLocator => By.XPath("//span[text()='edit info']");

    public By EditBoxInputLocator => By.Id("cfn");

    public By SaveButtonLocator => By.Id("bttn_sub");

    public By NamePlaceLocator => By.XPath("//td/div[@class='rc']");
    
    // Declaring elements
    public IWebElement AccountsLink => Driver.GetInstance().FindElement(AccountsLinkLocator);

    public IWebElement EditButton => Driver.GetInstance().FindElement(EditButtonLocator);

    public IWebElement EditBoxInput => Driver.GetInstance().FindElement(EditBoxInputLocator);

    public IWebElement SaveButton => Driver.GetInstance().FindElement(SaveButtonLocator);

    public IWebElement NamePlace => Driver.GetInstance().FindElement(NamePlaceLocator);
    
    // Declaring page methods
    public void ClickAccountLink()
    {
        WaitUtils.WaitForElementVisibility(AccountsLinkLocator);
        AccountsLink.Click();
    }

    public void ClickEditButton()
    {
        WaitUtils.WaitForElementVisibility(EditButtonLocator);
        WaitUtils.WaitForElementToBeClickable(EditButtonLocator);
        EditButton.Click();
    }

    public void EnterNewNickAndSave(string newNickname)
    {
        var tabs = Driver.GetInstance().WindowHandles;
        Driver.GetInstance().SwitchTo().Window(tabs[1]);
        EditBoxInput.Click();
        EditBoxInput.Clear();
        EditBoxInput.SendKeys(newNickname);
        SaveButton.Click();
    }

    public string GetNewNick()
    {
        var tabs = Driver.GetInstance().WindowHandles;
        Driver.GetInstance().SwitchTo().Window(tabs[0]);
        var name = NamePlace.Text.Split("<")[0].Trim();
        return name;
    }
}
