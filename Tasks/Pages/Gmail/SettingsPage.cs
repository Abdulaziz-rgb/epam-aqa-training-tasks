namespace ConsoleApp1.Pages.Gmail;

using Utils;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

public class SettingsPage
{
    // Declaring locators
    public By AccountsLinkLocator => By.XPath("//a[contains(@href,'accounts') and @role='tab']");

    public By EditButtonLocator => By.XPath("//span[text()='edit info']");

    public By EditBoxInputLocator => By.XPath("//input[@name='cfn']");

    public By SaveButtonLocator => By.XPath("//input[@type='submit']");

    // tried to change but not other option
    public By NamePlaceLocator => By.XPath("//td/div[@class='rc']"); 

    // Declaring elements
    public IWebElement AccountsLink => Driver.GetInstance().FindElement(AccountsLinkLocator);

    public IWebElement EditButton => Driver.GetInstance().FindElement(EditButtonLocator);

    public IWebElement EditBoxInput => Driver.GetInstance().FindElement(EditBoxInputLocator);

    public IWebElement SaveButton => Driver.GetInstance().FindElement(SaveButtonLocator);

    public IWebElement NamePlace => Driver.GetInstance().FindElement(NamePlaceLocator);

    public ReadOnlyCollection<string> Tabs => Driver.GetInstance().WindowHandles;

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
        Driver.GetInstance().SwitchTo().Window(Tabs[1]);
        EditBoxInput.Click();
        EditBoxInput.Clear();
        EditBoxInput.SendKeys(newNickname);
        SaveButton.Click();
    }

    public string GetNewNick()
    {
        Driver.GetInstance().SwitchTo().Window(Tabs[0]);
        WaitUtils.WaitForElementToBeClickable(NamePlaceLocator);
        
        return NamePlace.Text.Split("<")[0].Trim();
    }
}
