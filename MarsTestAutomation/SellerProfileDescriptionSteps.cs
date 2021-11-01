using MarsTestAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation
{
    [Binding]
    public class SPDescriptionSteps
    {
        [Given(@"I logged into Trade Skills portal successfully")]
        public void GivenILoggedIntoTradeSkillsPortalSuccessfully()
        {
            IWebDriver driver = new ChromeDriver();
            
            LoginPage loginObj = new LoginPage();
            loginObj.LoginAction(driver);
        }


        [Given(@"I click on pen icon")]
        public void GivenIClickOnPenIcon()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"I Add descricption and click Save button")]
        public void WhenIAddDescricptionAndClickSaveButton()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"Description should be saved successfully")]
        public void ThenDescriptionShouldBeSavedSuccessfully()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"I click Save button without data")]
        public void WhenIClickSaveButtonWithoutData()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"A popup should be shown with this message \(Please a Description is required\)")]
        public void ThenAPopupShouldBeShownWithThisMessagePleaseADescriptionIsRequired()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"I Edit descricption and click Save button")]
        public void WhenIEditDescricptionAndClickSaveButton()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"Description should be Edited successfully")]
        public void ThenDescriptionShouldBeEditedSuccessfully()
        {
            ScenarioContext.StepIsPending();
        }
    }
}