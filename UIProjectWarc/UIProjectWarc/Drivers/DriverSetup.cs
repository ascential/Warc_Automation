using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace UIProjectWarc.Drivers
{
    public class DriverSetup
    {
        public IWebDriver Driver;
        public void SetDriver()
        {
            var browser = Hooks.Config.Driver.ToLower();
            switch (browser) 
            
            {
                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                   
             Driver = new ChromeDriver()
             {
               
             };
                    break;

                default:
                    throw new Exception($"The browser{browser} is not currently implemented");

            
        }
            Driver.Manage().Cookies.DeleteAllCookies();          
          //  Thread.Sleep(4000);
            
            Driver.Manage().Window.Maximize();

        }
        
    }
}
