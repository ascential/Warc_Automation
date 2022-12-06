using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProjectWarc.Utils;

namespace UIProjectWarc.Pages
{
    public class DemoPage
    {
        private IWebDriver _driver;
        DriverWait driverwait;
        private By firstName  = By.XPath("(//input[@class='form-input-text'])[1]");
        private By lastName = By.XPath("(//input[@class='form-input-text'])[2]");
        private By phoneNumber = By.XPath("//input[@id='PhoneNumber']");
        private By emailAddress = By.XPath("//input[@id='EmailAddress']");
        private By jobTittle = By.XPath("//input[@name='JobTitle']");
        private By town = By.XPath("//input[@name='TownCity']");
        private By companyName = By.XPath("//input[@name='CompanyName']");
        private By businessDropdown = By.Id("category");
        private By businessList = By.XPath("//ul[@class='dropdown-menu show']/li/a");
        private By submit = By.XPath("//input[@value='Submit']");
        private By demoText = By.XPath("(//h4)[1]");
        private By brandList = By.XPath("//ul[@class='dropdown-menu sub-menu']/li/a");
        private By errorText = By.XPath("//span[@class='field-validation-error text-danger text-small']");
        private By demoTestimonialList = By.XPath("//div[@class='tile tile-std']/h5");

        public DemoPage(IWebDriver driver)
        {
            _driver = driver;
            driverwait= new DriverWait(driver);

        }
        public void EachBusinessType(Form form)
        {
            
            driverwait.WaitForElementToBeEnabled(businessDropdown);
            _driver.FindElement(businessDropdown).Click();
            IList<IWebElement> elements = _driver.FindElements(businessList);
            var element= elements.FirstOrDefault(e => e.Text.Equals(form.BusinessType,StringComparison.OrdinalIgnoreCase));
            if (element == null)
            {
                throw new Exception($"the business type {form.BusinessType} is not valid");

            }
            element.Click();
           
        }
        public void ClickSubmitButton()
        {
            var element = _driver.FindElement(submit);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)_driver;
            jse.ExecuteScript("arguments[0].scrollIntoView()", element);
            Thread.Sleep(1000);
            element.Click();

        }
        public bool IsDemoTextDisplayed()
        {
            return _driver.FindElement(demoText).Displayed;
        }
        public List<string> IsValidationErrorTextDisplayed()
        {
            IList<IWebElement> elements = _driver.FindElements(errorText);
            
            return elements.Select(e => e.Text).ToList();
            
        }
        public void DataFormEntry(Form form)
        {

            driverwait.WaitForElementToBeDisplayed(firstName);
            _driver.FindElement(firstName).SendKeys(form.Firstname);
            _driver.FindElement(lastName).SendKeys(form.Lastname);
            _driver.FindElement(phoneNumber).SendKeys(form.Phonenumber);
            _driver.FindElement(emailAddress).SendKeys(form.EmailAddress);
            _driver.FindElement(jobTittle).SendKeys(form.JobTitle);
            _driver.FindElement(town).SendKeys(form.Town);           
            _driver.FindElement(companyName).SendKeys(form.CompanyName);
            
        }
        public void EachBrandType(Form form)
        {          
            IList<IWebElement> elements = _driver.FindElements(brandList);
            var element = elements.FirstOrDefault(e => e.Text.Equals(form.Brand, StringComparison.OrdinalIgnoreCase));
            if (element == null)
            {
                throw new Exception($"the business type {form.Brand} is not valid");

            }
            element.Click();

        }
        public List<string> DemoTestimonial()
        {

            IList<IWebElement> elements= _driver.FindElements(demoTestimonialList);
            driverwait.ScrollToElements(elements);
           return elements.Select(e => e.Text).ToList();
        }

        public void IsValidationErrorTextDisplayed1()
        {
            IList<IWebElement> elements = _driver.FindElements(errorText);

           var t =  elements.Select(e => e.Text).ToList();
            if (t==null)
            {


            }

        }


    }
}
