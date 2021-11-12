using System;
using System.Threading;
using MarsTestAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsTestAutomation.Pages
{
    public class ProfilePage
    {
        private IWebElement descriptionField;
        private IWebElement skillNameField;
        private IWebElement skillLevelDropdownField;
        private IWebElement skillLevelDropdownOption;
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

            Wait.WaitForElementToBeClickable(driver, "CssSelector", "div[class='ns-box-inner']", 15);
            IWebElement popup = driver.FindElement(By.CssSelector("div[class='ns-box-inner']"));
            return popup.Text;
        }

// skill feild

        //Add skill
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
            skillNameField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillNameField.SendKeys("Testing");

           skillLevelDropdownField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdownField.Click();

           skillLevelDropdownOption = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            skillLevelDropdownOption.Click();

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

        // edit skill
        public void ClickEditPenIcon(IWebDriver driver)
        {
            ClickOnSkillsTab(driver);
            Thread.Sleep(5000); // WaitForElementToBeClickable method is not working here so used sleep method

            IWebElement editPenIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editPenIcon.Click();
        }

        public void UpdateSkillsData(IWebDriver driver, string skillName, string skillLevel)
        {
            skillNameField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            skillNameField.Clear();
            skillNameField.SendKeys(skillName);

            skillLevelDropdownField = driver.FindElement(By.XPath(
                  "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));

            //create select element object 
            var selectElement = new SelectElement(skillLevelDropdownField);

            // select by text
            selectElement.SelectByText(skillLevel);

            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();
        }

        // delete skill

        public void DeleteSkill(IWebDriver driver)
        {

            IWebElement clickOnDeleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            clickOnDeleteIcon.Click();
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