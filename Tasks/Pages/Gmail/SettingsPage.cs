namespace ConsoleApp1.Pages.Gmail;

using TestUtils;
using OpenQA.Selenium;

public class SettingsPage
{
    public IWebElement AccountsLink => Driver.GetInstance().FindElements(By.XPath("//a[@class='f0 LJOhwe']"))[1];

    public IWebElement EditButton => Driver.GetInstance().FindElements(By.CssSelector(".qy.CY"))[1];

    public IWebElement EditBoxInput => Driver.GetInstance().FindElement(By.Id("cfn"));

    public IWebElement SaveButton => Driver.GetInstance().FindElement(By.Id("bttn_sub"));

    public IWebElement NamePlace => Driver.GetInstance().FindElement(By.XPath("//td/div[@class='rc']"));
    
    public void ClickAccountLink()
    {
        WaitUtils.WaitForElementVisibility(By.XPath("//a[@class='f0 LJOhwe']"));
        AccountsLink.Click();
    }

    public void ClickEditButton()
    {
        WaitUtils.WaitForElementVisibility(By.CssSelector(".qy.CY"));
        WaitUtils.WaitForElementToBeClickable(By.CssSelector(".qy.CY"));
        EditButton.Click();
    }

    public void EnterNewNick(string newNickname)
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
