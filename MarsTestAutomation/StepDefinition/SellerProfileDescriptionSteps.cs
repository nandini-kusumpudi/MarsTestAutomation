using MarsTestAutomation.Pages;
using MarsTestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation
{
    [Binding]
    public class SPDescriptionSteps : CommonDriver
    {
        
        private ProfilePage descriptionObj;

        [OneTimeSetUp]
        public void Initialization()
        {
            descriptionObj = new ProfilePage();
        }
        
        [Given(@"I logged into Trade Skills portal successfully")]
        public void GivenILoggedIntoTradeSkillsPortalSuccessfully()
        {
            driver = new ChromeDriver();
            
            LoginPage loginObj = new LoginPage();
            loginObj.LoginAction(driver);
        }

        [Given(@"I click on pen icon")]
        public void GivenIClickOnPenIcon()
        {
            descriptionObj.ClickOnDescriptionPenIcon(driver);
        }

        [When(@"I Add '(.*)' and click Save button")]
        public void WhenIAddAndClickSaveButton(string Description)
        {
            descriptionObj.AddDescription(driver, Description);
        }

        [Then(@"'(.*)' should be saved successfully")]
        public void ThenShouldBeSavedSuccessfully(string Description)
        {
            string newDescription = descriptionObj.GetDescription(driver);
            Assert.That(newDescription == Description, "Description is not added");
        }

        [When(@"I click Save button without data")]
        public void WhenIClickSaveButtonWithoutData()
        {
            descriptionObj.AddDescription(driver,"");
        }

        [Then(@"A popup should be shown with '(.*)'")]
        public void ThenAPopupShouldBeShownWith(string message)
        {
            string popUpMessage = descriptionObj.GetPopUpMessage(driver);
            Assert.AreEqual(popUpMessage, message );
        }
    }
}