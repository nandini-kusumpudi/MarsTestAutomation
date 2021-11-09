using MarsTestAutomation.Pages;
using MarsTestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.StepDefinition
{
    [Binding]
    public class SellerProfileSteps : CommonDriver

    {
        private ProfilePage sellerProfileObj;

        [BeforeScenario]
        public void Initialization()
        {
            sellerProfileObj = new ProfilePage();
        }

        [Given(@"I click on name expand icon")]
        public void GivenIClickOnNameExpandIcon()
        {
            sellerProfileObj.SelectSellerNameDropDown(driver);
        }

        [When(@"I enter First Name, Last Name and click on Save button")]
        public void WhenIEnterFirstNameLastNameAndClickOnSaveButton()
        {
            sellerProfileObj.EditSellerProfile(driver);
        }

        [Then(@"Name should be saved successfully")]
        public void ThenNameShouldBeSavedSuccessfully()
        {
            string updatedSellerName = sellerProfileObj.GetSellerprofileName(driver);
            Assert.AreEqual("nandini kusumpudi", updatedSellerName);
        }
    }
}