using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProjectWarc.Pages;
using UIProjectWarc.Utils;

namespace UIProjectWarc
{
    internal class HomePage 
    {
        private IWebDriver _driver;
        DriverWait driverwait;
        HelperClass _helperClass;
        //private By cookiesBtn = By.Id("onetrust-accept-btn-handler");
        private static By cookiesBtn = By.XPath("//button[text()='Accept All Cookies']");
        private static By hideMessageBtn = By.Id("//div[@id='cookieNotice_acceptCookies']/following-sibling::text()");
        private By getADemoBtn = By.XPath("//a[@class='link-accent link-item']");
        private By menuButton = By.XPath("//button[@class='button-image-round button-hamburger']");
        private By menuList = By.XPath("//a[@class='label-pillar']");
        By[] cookies = new By[] { cookiesBtn, hideMessageBtn };
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            driverwait = new DriverWait(driver);
           _helperClass = new HelperClass(driver);
                
        }
        public void ClickCookies()
        {
         
            _driver.Navigate().GoToUrl(Hooks.Config.Url);
            Thread.Sleep(3000);
            foreach (var item in cookies)
            {
                _helperClass.ClickDisplayedElement(item);

            }
            
            

        }
        public void ClickGetADemo()
        {
            
            _driver.FindElement(getADemoBtn).Click();    

        }
        public void ClickMenuButton()
        {
            _driver.FindElement(menuButton).Click();
        }
        public List<string> EachPillarSection()
        { 
            driverwait.WaitForElementToBeDisplayed(menuList);
            IList<IWebElement> elements= _driver.FindElements(menuList);
            return elements.Select(e=>e.Text).ToList();
        }
    }
}
