using RestSharpAPI.APIMethods;
using System;
using TechTalk.SpecFlow;

namespace RestSharpAPI
{
    [Binding]
    public class APIStepDefinitions
    {
        CommonMethods commonmethods = new CommonMethods();
        [Given(@"\[context]")]
        public void GivenContext()
        {
            commonmethods.GetRequest(); 
        }

        [When(@"\[action]")]
        public void WhenAction()
        {
            commonmethods.CreateBooking();
        }

        [Then(@"\[outcome]")]
        public void ThenOutcome()
        {
            commonmethods.Auth();
            commonmethods.Delete();
        }
    }
}
