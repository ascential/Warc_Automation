using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectWarc.Pages
{
    internal class HelperClass
    {
        private IWebDriver _driver;        
        public HelperClass(IWebDriver driver)
        {
            _driver = driver;

        }

        public bool IsElementDisplayed(By value)
        {
            try
            {
              var check = _driver.FindElement(value).Displayed;
                return check;

            }
            catch
            {          
                return false;
            }
            return false;
        }
        public void SwitchToTab2(string URL)
        {
            Thread.Sleep(5000);
            _driver.FindElement(By.CssSelector("Body")).SendKeys(Keys.Command + "t");
            _driver.Url = "https://warc.com/" + URL;
            Thread.Sleep(2000);

        }
        public bool ClickDisplayedElement(By value)
        {
            try
            {
                Thread.Sleep(2000);
                _driver.FindElement(value).Click();

            }
            catch
            {
                return false;
            }
            return false;
        }


    }

    }

