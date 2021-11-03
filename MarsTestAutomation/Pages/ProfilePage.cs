using System;
using MarsTestAutomation.Utilities;
using OpenQA.Selenium;
namespace MarsTestAutomation.Pages
{
    public class ProfilePage
    {
        public void ClickOnDescriptionPenIcon(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i",
                15);
            
            IWebElement descriptionPenIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionPenIcon.Click();
        }
        
        public void AddDescription(IWebDriver driver, string Description)
        {
            IWebElement descriptionAdd = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionAdd.Clear();
            descriptionAdd.SendKeys(Description);

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();
        }

        public String GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            return newDescription.Text; 
        }
        public String GetPopUpMessage(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "/html/body/div[1]/div", 10);
            IWebElement newDescriptionWithoutData = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            return newDescriptionWithoutData.Text; 
        }
        
    }
}