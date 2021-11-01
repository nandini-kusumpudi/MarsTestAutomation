using TechTalk.SpecFlow;

namespace MarsTestAutomation
{
    [Binding]
    public class SellerProfileSteps
    {
        [Given(@"I click on name expand icon")]
        public void GivenIClickOnNameExpandIcon()
        {
            ScenarioContext.StepIsPending();
        }
    }
}