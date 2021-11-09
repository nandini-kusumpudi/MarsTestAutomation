using System;
using MarsTestAutomation.Utilities;
using OpenQA.Selenium;

namespace MarsTestAutomation.Pages
{
    public class ProfilePage
    {
        private IWebElement descriptionField;
        private IWebElement skillsField;
        private IWebElement sellerProfileField;

        public void ClickOnDescriptionPenIcon(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i",
                15);

            IWebElement descriptionPenIcon = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionPenIcon.Click();
        }

        public void AddDescription(IWebDriver driver, string description)
        {
            descriptionField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionField.Clear();
            descriptionField.SendKeys(description);

            IWebElement saveButton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();
        }

        public String GetDescription(IWebDriver driver)
        {
            descriptionField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            return descriptionField.Text;
        }

        public String GetPopUpMessage(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "/html/body/div[1]/div", 10);
            IWebElement popup = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            return popup.Text;
        }

// skill feild
        public void ClickOnSkillsTab(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]",
                15);

            IWebElement skill = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skill.Click();
        }

        public void cliclOnAddNewButton(IWebDriver driver)
        {
            IWebElement addButton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addButton.Click();
        }

        public void enterDataInSkillsFeild(IWebDriver driver)
        {
            IWebElement addSkill = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkill.SendKeys("Testing");

            IWebElement clickChooseSkillLevelDropDown = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            clickChooseSkillLevelDropDown.Click();
            IWebElement selectChooseSkillLevel = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            selectChooseSkillLevel.Click();

            IWebElement clickAddbutton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            clickAddbutton.Click();
        }

        public String GetSkillsAddPopUpMessage(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "CssSelector", "div[class='ns-box-inner']", 15);
            IWebElement popup = driver.FindElement(By.CssSelector("div[class='ns-box-inner']"));
            return popup.Text;
        }

        // seller profile
        public void SelectSellerNameDropDown(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i",
                15);

            IWebElement sellerDropdown = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            sellerDropdown.Click();
        }

        public void EditSellerProfile(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "CssSelector", "input[name='firstName']", 15);

            IWebElement firstName = driver.FindElement(By.CssSelector("input[name='firstName']"));
            firstName.Clear();
            firstName.SendKeys("nandini");

            IWebElement lastName = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            lastName.Clear();
            lastName.SendKeys("kusumpudi");

            IWebElement savaButton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            savaButton.Click();
        }

        public String GetSellerprofileName(IWebDriver driver)
        {
            sellerProfileField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
            return sellerProfileField.Text;
        }
    }
}