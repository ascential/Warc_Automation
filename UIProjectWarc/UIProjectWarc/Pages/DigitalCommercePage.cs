using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProjectWarc.Utils;

namespace UIProjectWarc.Pages
{
    internal class DigitalCommercePage
    {
        public string method1="Amazon";
        public string method2 = "Instacart";
        public string method3 = "Walmart";
        private IWebDriver _driver;
        private DriverWait driverWait;
        private HelperClass helperClass;
        private By cookiesBtn = By.Id("onetrust-accept-btn-handler");
        private By signInBtn = By.XPath("(//a[@id='loginLinkMobile'])[1]");
        private By userName = By.Id("EmailAddress");
        private By passWord = By.Id("Password");
        private By signIn = By.Id("loginFormSubmit");
        private By howToWin = By.XPath("//div[@class='col']");
        private By BestPractice = By.XPath("(//a[@href='/digital-commerce/best-practice'])[4]");
        private By methodologyList = By.XPath("//div[@class='expandable-title-teal']");
        private By digitalCommerce = By.XPath("(//a[@href='/digital-commerce'])[1]");
        private By methodology = By.XPath("(//a[@href='/digital-commerce/methodology'])[3]");
        static private By amazon = By.XPath("//a[text()='Amazon']");
        static private By walmart = By.XPath("//a[text()='Walmart']");
        static private By instacart = By.XPath("//a[text()='Instacart']");
        static private By caseStudy1 = By.XPath("//h4[text()='Sitting pretty: How Hero Cosmetics tripled sales by adapting to new platforms']");
        static private By caseStudy2 = By.XPath("How Heyday is building a “next generation”, digital-first CPG company");
        static private By caseStudy3 = By.XPath("//h4[text()='Secret Sauce: How Mike’s Hot Honey became an Amazon bestseller']");
        static private By caseStudy4 = By.XPath("//h4[text()='//h4[text()='How Heroes optimised its online advertising to double global sales within months']']");
        static private By cpgbrands = By.XPath("//a[text()='How and when emerging CPG brands should launch on Amazon']");
        static private By walmartSearch = By.XPath("//a[text()='How and when emerging CPG brands should launch on Amazon']");

        By[] caseStudy = new By[] { caseStudy1, caseStudy2, caseStudy3, caseStudy4 };
        By[] method = new By[] { amazon, walmart, instacart };
        By[] howToWinList= new By[] { cpgbrands, walmartSearch }; 
        public DigitalCommercePage(IWebDriver driver)
        {
            _driver = driver;
            driverWait = new DriverWait(driver);
            helperClass = new HelperClass(driver);
        }

        public void ClickCookies()
        {
            _driver.Navigate().GoToUrl(Hooks.Config.Url);
            Thread.Sleep(3000);
            _driver.FindElement(cookiesBtn).Click();

        }

        public void EnterLoginCredential(String username,string password)
        {
            _driver.FindElement(signInBtn).Click();
            Thread.Sleep(500);
            _driver.FindElement(userName).SendKeys(username);
            _driver.FindElement(passWord).SendKeys(password);
            _driver.FindElement(signIn).Click();
        }
        public void ClickDigitalCommerce()
        {
            driverWait.WaitForElementToBeDisplayed(digitalCommerce);           
            _driver.FindElement(digitalCommerce).Click();
        }
        public void ClickMethodology()
        {
            driverWait.WaitForElementToBeDisplayed(digitalCommerce);
             var element= _driver.FindElement(methodology);
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
             element.Click();    
        }
        public bool VerifyMethodology()
        {
            foreach (var item in method)
            {
              helperClass.IsElementDisplayed(item);

            }
            return true;
        }

        public void ClickBestPractice()
        {
            driverWait.WaitForElementToBeDisplayed(digitalCommerce);
            var element = _driver.FindElement(BestPractice);
            driverWait.ScrollToElement(element);
            Thread.Sleep(500);
            element.Click();
            
        }

        public bool IsCaseStudyDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(digitalCommerce);
            var element = _driver.FindElement(By.XPath("(//a[@class='content-image'])[1]"));
            driverWait.ScrollToElement(element);
        
            foreach (var item in caseStudy)
            {
                helperClass.IsElementDisplayed(item);

            }
            return true;
        }

        public bool IsHowToWinDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(digitalCommerce);
            var element = _driver.FindElement(howToWin);
            driverWait.ScrollToElement(element);

            foreach (var item in howToWinList)
            {
                helperClass.IsElementDisplayed(item);

            }
            return true;
        }
    }
    }

