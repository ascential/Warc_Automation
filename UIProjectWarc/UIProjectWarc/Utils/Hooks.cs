using BoDi;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using UIProjectWarc.Drivers;
using UIProjectWarc.Utils;

namespace UIProjectWarc
{
    [Binding]
    public class Hooks
    {

        public static TestConfig Config;
        private IObjectContainer objectContainer;
        private DriverSetup _driversetup;  

        public Hooks(IObjectContainer objectContainer)=>
        
            this.objectContainer = objectContainer;

        

       
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            var browser = Environment.GetEnvironmentVariable("browser");
            var config= new ConfigurationBuilder()
                .AddJsonFile("AppSettings.json")
                .Build();
            Config = new TestConfig();
            config.GetSection("TestConfig").Bind(Config);
            if (!string.IsNullOrEmpty(browser))
                Config.Driver = browser;
            

            
        }

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            _driversetup = new DriverSetup();
            _driversetup.SetDriver();
            objectContainer.RegisterInstanceAs(_driversetup.Driver);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}