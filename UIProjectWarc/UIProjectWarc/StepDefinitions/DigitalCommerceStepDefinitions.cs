using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UIProjectWarc.Pages;

namespace UIProjectWarc.StepDefinitions
{
    [Binding]
    public class DigitalCommerceStepDefinitions
    {

        private DigitalCommercePage digitalCommercePage;
        public DigitalCommerceStepDefinitions(IWebDriver driver)
        {
            digitalCommercePage = new DigitalCommercePage(driver);
        }
        [Given(@"Im a digital commerce client on WarcUI")]
        public void GivenImADigitalCommerceClientOnWarcUI()
        {
            digitalCommercePage.ClickCookies();
        }

        [When(@"I enter my username and password")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            digitalCommercePage.EnterLoginCredential("deborah.fisayo@ascential.com", "Shindara1.");
        }

        [When(@"I click on digital commerce")]
        public void WhenIClickOnDigitalCommerce()
        {
            digitalCommercePage.ClickDigitalCommerce();
        }

        [When(@"click on methodology")]
        public void WhenClickOnMethodology()
        {
            digitalCommercePage.ClickMethodology();
        }        
        [Then(@"dcom index is displayed")]
        public void ThenDcomIndexIsDisplayed()
        {
            Assert.True(digitalCommercePage.VerifyMethodology());
        }
        [When(@"click on Best Practice")]
        public void WhenClickOnBestPractice()
        {
            digitalCommercePage.ClickBestPractice();
        }

        [Then(@"casestudies are displayed")]
        public void ThenCasestudiesAreDisplayed()
        {
            digitalCommercePage.IsCaseStudyDisplayed();
        }


        [Then(@"How and when emerging CPG brands should launch on Amazon is displayed And Winning on Walmart Paid Search")]
        public void ThenHowAndWhenEmergingCPGBrandsShouldLaunchOnAmazonIsDisplayedAndWinningOnWalmartPaidSearch()
        {
            digitalCommercePage.IsHowToWinDisplayed();
        }
    }
}
