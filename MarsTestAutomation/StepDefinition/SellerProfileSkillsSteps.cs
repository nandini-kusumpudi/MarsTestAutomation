using MarsTestAutomation.Pages;
using MarsTestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.StepDefinition
{
    [Binding]
    public class SellerProfileSkillsSteps : CommonDriver
    {
        private ProfilePage skillObj;

        [BeforeScenario]
        public void Initialization()
        {
            skillObj = new ProfilePage();
        }

        [Given(@"I click on skills tab")]
        public void GivenIClickOnSkills()
        {
            skillObj.ClickOnSkillsTab(driver);
        }

        [Given(@"I click on Add New button")]
        public void GivenIClickOnAddNewButton()
        {
            skillObj.cliclOnAddNewButton(driver);
        }

        [When(@"I Enter the data in Skills and Chose Skill level and click on Add button")]
        public void WhenIEnterTheDataInSkillsAndChoseSkillLevelAndClickOnAddButton()
        {
            skillObj.enterDataInSkillsFeild(driver);
        }


        [Then(@"A popup '(.*)' should be shown")]
        public void ThenAPopupShouldBeShown(string message)
        {
            string skillsPopUpMessage = skillObj.GetSkillsAddPopUpMessage(driver);
            Assert.AreEqual(message, skillsPopUpMessage);
        }
    }
}