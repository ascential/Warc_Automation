using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIProjectWarc.Pages;

namespace UIProjectWarc.StepDefinitions
{
    [Binding]
    public class DemoPageStepDefinitions
    {
        private IWebDriver _driver;
        private DemoPage _demoPage;
        public DemoPageStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _demoPage = new DemoPage(driver);
        }

        [Given(@"the data entry form is displayed")]
        public void GivenTheDataEntryFormIsDisplayed()
        {
            Assert.True(_demoPage.IsDemoTextDisplayed(), "Schedule your live demo with our team today");
        }


        [Given(@"I enter the following data")]
        public void GivenIEnterTheFollowingData(Table table)
        {
            var form = table.CreateInstance<Form>();
            _demoPage.DataFormEntry(form);
            _demoPage.EachBusinessType(form);
            _demoPage.EachBrandType(form);
        }

        [When(@"i click the submit button")]
        public void WhenIClickTheSubmitButton()
        {
            _demoPage.ClickSubmitButton();
        }

        [Then(@"the error message '(.*)' is displayed")]
        public void ThenTheErrorMessageIsDisplayed(string errorText)
        {
            var s = _demoPage.IsValidationErrorTextDisplayed();
            var errorIsPresent = _demoPage.IsValidationErrorTextDisplayed().Any(text => text.Equals(errorText));
            Assert.IsTrue(errorIsPresent);

        }
        [Then(@"the '(.*)' is displayed")]
        public void ThenTheIsDisplayed(string demoTestimonial)
        {
           var textIsPresent= _demoPage.DemoTestimonial().Any(text=>text.Equals(demoTestimonial));
            Assert.IsTrue(textIsPresent);   
        }

    }
}
