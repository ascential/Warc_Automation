using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace UIProjectWarc.StepDefinitions
{
    [Binding]
    public class HomePageStepDefinitions
         
    {
        private IWebDriver _driver;
        private HomePage _homePage;
        public HomePageStepDefinitions(IWebDriver driver)
        {
            _driver = driver; 
            _homePage= new HomePage(driver);
        }   
         
        
        [Given(@"Im a customer on Warc UI")]
        public void GivenImACustomerOnWarcUI()
        {
            _homePage.ClickCookies();  
                
        }


        [When(@"i click on “Get a demo” on the header")]
        public void WhenIClickOnGetADemoOnTheHeader()
        {
            _homePage.ClickGetADemo();
        }

        [Then(@"a data entry form is displayed\.")]
        public void ThenADataEntryFormIsDisplayed_()
        {      
                Assert.True(_driver.Title.Contains("Get a Demo | WARC"));
            
        }
        
        [When(@"i click on the burger menu")]
        public void WhenIClickOnTheBurgerMenu()
        {
            _homePage.ClickMenuButton();
        }

        [Then(@"the below is displayed '(.*)'")]
        public void ThenTheBelowIsDisplayed(string pillarSection)
        {
            var t=_homePage.EachPillarSection();
           var textIsPresent= _homePage.EachPillarSection().Any(text =>text.Equals(pillarSection));
            Assert.True(textIsPresent);

        }


    }
}
