using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectWarc.Utils
{
    public class DriverWait
    {
        IWebDriver driver;
      private WebDriverWait wait;
        public DriverWait(IWebDriver driver)
        {
            this.driver = driver;
            wait =new WebDriverWait(driver,TimeSpan.FromSeconds(30));
            
        }
        public void WaitForElementToBeDisplayed(By locator)
        {
            wait.Until(d => d.FindElement(locator).Displayed); 
        }

        public void WaitForUrlToChange(string url)
        {
            wait.Until(d => d.Url != url);
        }

        public void WaitForElementToBeEnabled(By locator)
        {
            wait.Until(d => d.FindElement(locator).Enabled);
        }
        public void ScrollToElements(IList<IWebElement> element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].scrollIntoView()", element);
        }
        public void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].scrollIntoView()", element);
        }

        public void WaitUntilPageHasLoaded()
        {
            wait.Until(
d => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void WaitForAjax()
        {
           
            wait.Until(d => (bool)((IJavaScriptExecutor)driver).ExecuteScript("return jQuery.active == 0"));
        }
        
    }
}
