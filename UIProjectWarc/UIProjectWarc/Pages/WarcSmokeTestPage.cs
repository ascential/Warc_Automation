using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProjectWarc.Utils;

namespace UIProjectWarc.Pages
{
    internal class WarcSmokeTestPage
    {
        private IWebDriver _driver;
        private HelperClass _helperClass;
        static private By strategy = By.XPath("//a[text()='Strategy']");
        static private By creative = By.XPath("//a[text()='Creative']");
        static private By media = By.XPath("//a[text()='Media']");
        static private By findOutMore = By.XPath("(//a[@class='size-small'])[1]");
        private By signUp = By.XPath("(//a[@href='/newsandopinion/getnews'])[3]");
        private By getADemo = By.XPath("(//a[@href='/demo'])[3]");
        private By getADemoText = By.XPath("//h4[text()='Schedule your live demo with our team today']");
        private By signUpText = By.XPath("//h1[text()='Sign up for our free daily newsletter']");
        private By contactUp = By.XPath("(//a[@href='/contact-us'])[1]");
        private By comparePlans = By.XPath("(//a[@href='/compare-plans'])[1]");
        private By comparePlansText = By.XPath("//h1[text()='Choose the plan that’s right for you']");
        private By searchBox = By.XPath("//input[@name='q']");
        private By socialMediaLink = By.XPath("//ul[@class='footer-social']/li//img");
        private By TwitterText = By.XPath("(//ul[@class='footer-social']/li//img)[2]");
        private By signInText = By.XPath("(//a[text()='Sign in'])[1]");
        private By aboutStrategyText = By.XPath("//h1[normalize-space(text())]");
        private By aboutMediaText = By.XPath("//h1[normalize-space(text())]");
        //By[] homeLinkText=new By[] {  aboutMediaText };
        string[] recommendationItems = new string[] { "Office For National Statistics: Census 2021", " Savlon: Surface disinfectant – Putting the fun in disinfection" };
        private By contactUpText = By.XPath("//h1[text()='We’d love to hear from you']");
        private By HomeFooterLinks = By.XPath("//div[@class='footer-col-1']/ul/li/a");
        string paywall = "See everything on this Topic - and sign up for Topic Updates']";
        private By findOutMoreText = By.XPath("//h1[contains(text(),'The WARC Consumer Trends Report 2022: Coping in an era of serial crises ')]");
        private DriverWait driverWait;
        private By recommendedText = By.XPath("//p[text()='Recommended']");
        private By caseFinder = By.XPath("(//a[@href='/case-finder'])[1]");
        private By caseFinderText = By.XPath("//p[text()='Search for advertising effectiveness case studies']");
        private By cancel = By.XPath("//button[@class='button-image-round bg-white button-menu-close']");
        private By paywallContent = By.XPath(" //div[text()='See everything on this Topic - and sign up for Topic Updates']");
        By[] pillars = new By[] { strategy, creative, media };
        private By recommendationItemsList = By.XPath("//*[@class='content-details']/a[normalize-space(text())]");
        private By FooterLinkSections = By.XPath("//div[@class='footer-links styled-links']/div/div//ul");
        private int FooterLinkSectionsIndex;
        private By alcoholicDrinks = By.XPath("(//a[@href='/topics/categories/Alcoholic-drinks'])[3]");
        private By benin = By.XPath("(//a[@href='/topics/geographies/africa/benin'])[3]");
        private By fullWarcGuideTxt = By.XPath("//h1[text()='The full WARC Guide collection']");
        private By viewWarcGuideBtn = By.XPath("(//a[@href='/warc-guide/full-collection'])[2]");
        private By FooterSubLinks => By.XPath($"(//div[@class='footer-links styled-links']/div/div//ul)[{FooterLinkSectionsIndex}]/li/a");
        private By askWarcbtn = By.XPath("(//a[@href='/warcplus'])[2]");
        private By askQstnText = By.XPath("//a[text()='Ask a question']");
        private By mediaBtn = By.XPath("(//a[@href='/media'])[5]");
        private By mediaText = By.XPath("//h3[text()='Welcome to WARC Media']");
        private By searchBtn = By.XPath("//input[@class='search-input-submit']");
        private By moreFilterBtn = By.XPath("//div[@class='all-filters-button']");
        private By consumersTopics = By.XPath("//span[text()='Consumers & audiences  (19137) ']");
        private By pharmaAndHealthcare = By.XPath("//a[text()='What we know about pharma and healthcare marketing in the US']");
        private By saveArticleBtn = By.XPath("(//a[@class='dropdown-toggle'])[3]");
        private By folderName = By.XPath("//input[@name='foldername']");
        private By createBtn = By.XPath("//input[@name='create']");
        private By pdfBtn = By.XPath("//a[@href='/content/export/d26c05d9-b891-460b-ad66-30a787662865/en-GB']");
        private By brandPrdtLaunch = By.XPath("(//a[@href='/topics/brands-branding/brand_product-launches'])[3]");
        private By alcoholicDrinksText = By.XPath("//a[text()='Alcoholic drinks']");
        private By argentinaText = By.XPath("//a[text()='Argentina']");
        private By cmoStruggleBtn = By.XPath("(//div[@class='feed-item-details'])[2]");
        private By cmoStruggleText = By.XPath("(//h5[text()='CMOs struggle to get to grips with data ethics'])[2]");
        private By categoriesBtn = By.XPath("(//a[text()='Categories'])[2]");
        private By findCaseBtn = By.XPath("//a[@id='findCaseLink']");
        private By podcastBtn = By.XPath("//a[@href='#podcast']");
        private By webinarBtn = By.XPath("//a[@href='#webinars']");
        private By lastestWebinarsText = By.XPath("//h3[text()='Latest webinars']");
        private By podcastCurrentText = By.XPath("//h3[text()='Current episodes']");
        private By whatWeKnowText = By.XPath("//a[@href='#whatweknowabout']");
        private By whatWeKnow = By.XPath("//h3[text()='What We Know About']");
        private By partnerAwardsText = By.XPath("//h1[text()='Partner award case studies']");
        private By whatsWorkingIn = By.XPath("//a[@href='#wwi']");
        private By whatsWorkingInTxt = By.XPath("//*[@id='wwi']/div/h3");
        private By reasearchList = By.XPath("//div[@class='tile-content tile-content-matched']");
        private By journalWebsite = By.XPath("//a[@href='http://www.journalofadvertisingresearch.com/']");
        private By journalLogin = By.XPath("//a[text()='Log in']");
        private By strategyModules = By.XPath("//div[@class='containing-box-links tile-endbutton w-100']");
        private By strategyTxt = By.XPath("//div[@class='container-fluid']/ul/li");
        private By PitchBuilder = By.XPath("//a[@href='/pitchsupport/pitchbuilder']");
        private By pitchBuilderTxt = By.XPath("//h1[text()='Pitch Builder']");
        private By newBusinessGuide = By.XPath("//a[@href='/new-business-guide.info']");
        public WarcSmokeTestPage(IWebDriver driver)
        {
            _driver = driver;
            _helperClass = new HelperClass(driver);
            driverWait = new DriverWait(driver);
        }

        public bool MenuItemIsDisplayed()
        {
            foreach (var item in pillars)
            {
                _helperClass.IsElementDisplayed(item);
            }
            return true;
        }
        public void ClickCancel()
        {
            _driver.FindElement(cancel).Click();
        }
        public void ClickFindMore()
        {
            _driver.FindElement(findOutMore).Click();
            Thread.Sleep(3000);
        }
        public bool FindMoreTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(findOutMoreText);
            return _driver.FindElement(findOutMoreText).Displayed;
        }
        public void ClickSignup()
        {
            driverWait.WaitForElementToBeDisplayed(findOutMore);
            var element = _driver.FindElement(signUp);
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
            element.Click();
        }
        public bool SignupTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(signUpText);
            return _driver.FindElement(signUpText).Displayed;
        }
        public void ClickContactup()
        {
            driverWait.WaitForElementToBeDisplayed(findOutMore);
            var element = _driver.FindElement(contactUp);
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
            element.Click();
        }
        public bool ContactUsTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(contactUpText);
            return _driver.FindElement(contactUpText).Displayed;
        }
        public void ClickGetADemo()
        {
            driverWait.WaitForElementToBeDisplayed(findOutMore);
            var element = _driver.FindElement(getADemo);
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
            element.Click();
        }
        public bool GetADemoIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(getADemoText);
            return _driver.FindElement(getADemoText).Displayed;
        }
        public void ClickComparePlans()
        {
            driverWait.WaitForElementToBeDisplayed(findOutMore);
            var element = _driver.FindElement(comparePlans);
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
            element.Click();
        }
        public bool ComparePlansTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(comparePlansText);
            return _driver.FindElement(comparePlansText).Displayed;
        }
        public void SearchBoxField(string searchBoxValue)
        {
            driverWait.WaitForElementToBeDisplayed(signInText);
            _driver.FindElement(searchBox).Click();
            _driver.FindElement(searchBox).SendKeys(searchBoxValue);
            _driver.FindElement(searchBox).SendKeys(Keys.Enter);

        }
        public bool PaywallContentIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(paywallContent);
            return _driver.FindElement(paywallContent).Displayed;
        }
        public IList<IWebElement> SocialMedia()
        {
            return _driver.FindElements(socialMediaLink);
        }

        public bool SocialMediaIsDisplayed(string value)
        {
            foreach (var item in SocialMedia())
            {
                if (item.GetAttribute("alt").Contains(value))
                {
                    item.Equals(value);
                }

            }
            return true;
        }

        public void ScrollToSocialMediaFooter()
        {
            driverWait.WaitForElementToBeDisplayed(TwitterText);
            var element = _driver.FindElement(TwitterText);
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

        }

        public void ScrollToBottomOfPage()
        {

            Thread.Sleep(15000);
            driverWait.WaitUntilPageHasLoaded();
            driverWait.WaitForAjax();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(4000);
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

        }
        public void VerifyHomeFooterLinks(WarcFooterLinks warcFooterLinks)
        {
            driverWait.WaitForElementToBeDisplayed(HomeFooterLinks);
            IList<IWebElement> elements = _driver.FindElements(HomeFooterLinks);

            var element = elements.FirstOrDefault(e => e.Text.Equals(warcFooterLinks.Home, StringComparison.OrdinalIgnoreCase));
            if (element == null)
            {
                throw new Exception($"the business type {warcFooterLinks.Home} is not valid");

            }
            element.Click();
            driverWait.WaitForElementToBeDisplayed(aboutStrategyText);
            _helperClass.IsElementDisplayed(aboutStrategyText).Equals(warcFooterLinks.VerifyLink);

        }

        public void VerifyHomeFooterLinks(string section)
        {
            driverWait.WaitForElementToBeDisplayed(FooterLinkSections);
            IList<IWebElement> elements = _driver.FindElements(FooterLinkSections);
            var element = elements.FirstOrDefault(e => e.Text.Split("\r\n").First().Equals(section, StringComparison.OrdinalIgnoreCase));

            if (element == null)
            {
                throw new Exception($"the business type {section} is not valid");

            }
            FooterLinkSectionsIndex = elements.IndexOf(element) + 1;
            var subLinks = element.FindElements(FooterSubLinks).ToList();
            var url = _driver.Url;
            List<string> errors = new List<string>();
            for (int i = 1; i < subLinks.Count; i++)
            {
                var link = subLinks[i];

                link.Click();
                driverWait.WaitForUrlToChange(url);
                url = _driver.Url;
                if (!CheckPage.DoesUrlExists(url).Result)
                    errors.Add(link.Text);
                _driver.Navigate().Back();
                driverWait.WaitForUrlToChange(url);
                url = _driver.Url;
                ScrollToBottomOfPage();
                driverWait.WaitForElementToBeDisplayed(FooterLinkSections);
                subLinks = _driver.FindElements(FooterSubLinks).ToList();
            }

            if (errors.Any())
                throw new Exception($"The following errors were found : {string.Join(" ,", errors)}");

            //  driverWait.WaitForElementToBeDisplayed(aboutStrategyText);
            //    _helperClass.IsElementDisplayed(aboutStrategyText).Equals(warcFooterLinks.VerifyLink);

        }
        public bool VerifyHomeLinksText(WarcFooterLinks warcFooterLinks)
        {
            var t = _driver.FindElement(aboutStrategyText);
            if (t.Text.Contains(warcFooterLinks.VerifyLink))
            {
            }
            return true;
        }

        public List<string> VerifyRecommendedItems()
        {

            IList<IWebElement> elements = _driver.FindElements(recommendationItemsList);
            driverWait.WaitForElementToBeDisplayed(recommendedText);
            var e = elements.Select(e => e.Text).ToList();
            return e;
        }
        public void ClickCaseFinder()
        {
            driverWait.WaitForElementToBeDisplayed(recommendedText);
            Thread.Sleep(5000);
            var element = _driver.FindElement(caseFinder);
            IJavaScriptExecutor j = (IJavaScriptExecutor)_driver;
            j.ExecuteScript("arguments[0].scrollIntoView({block: 'center', inline: 'nearest'})", element);
            //((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(5000);
            element.Click();
        }
        public bool VerifyCaseFinderText()
        {
            driverWait.WaitForElementToBeDisplayed(caseFinderText);
            return _driver.FindElement(caseFinderText).Displayed;
        }
        public void ClickAskWarc()
        {
            driverWait.WaitForElementToBeDisplayed(recommendedText);
            Thread.Sleep(5000);
            var element = _driver.FindElement(askWarcbtn);
            IJavaScriptExecutor j = (IJavaScriptExecutor)_driver;
            j.ExecuteScript("arguments[0].scrollIntoView({block: 'center', inline: 'nearest'})", element);
            Thread.Sleep(5000);
            element.Click();
        }
        public bool VerifyAskQstnText()
        {
            driverWait.WaitForElementToBeDisplayed(askQstnText);
            return _driver.FindElement(askQstnText).Displayed;
        }
        public void ClickMedia()
        {
            driverWait.WaitForElementToBeDisplayed(recommendedText);
            Thread.Sleep(5000);
            var element = _driver.FindElement(mediaBtn);
            IJavaScriptExecutor j = (IJavaScriptExecutor)_driver;
            j.ExecuteScript("arguments[0].scrollIntoView({block: 'center', inline: 'nearest'})", element);
            Thread.Sleep(5000);
            element.Click();
        }
        public bool VerifyMediaText()
        {
            driverWait.WaitForElementToBeDisplayed(mediaText);
            return _driver.FindElement(mediaText).Displayed;
        }

        public void VerifySearchFilter(string section)

        {
            Thread.Sleep(10000);
            var elements=  _driver.FindElements(By.XPath("//div[@class='card-header']"));
            List<string> errors = new List<string>();
            
            foreach (var item in elements)
            {
                if (!item.Displayed)
                {
                    errors.Add(item.Text);  

                }
            }
            if (errors.Any())
                throw new Exception($"The following errors were found : {string.Join(" ,", section)}");

        }
        public void ClickSearchIcon()
        {
            driverWait.WaitForElementToBeDisplayed(recommendedText);
            Thread.Sleep(5000);
            var element = _driver.FindElement(searchBtn);
            element.Click();
            driverWait.WaitForElementToBeDisplayed(moreFilterBtn);
            _driver.FindElement(moreFilterBtn).Click();

        }
          public void ClickOnFilter(string filter)
        {
            var elements = _driver.FindElements(By.XPath("//div[@class='card-header']"));
            foreach (var item in elements)
            {
                if (item.Text.Contains(filter))
                {
                    Thread.Sleep(5000);
                    item.Click();
                    break;
                }
            }
        }

        public void TickConsumerTopics()
        {
            driverWait.WaitForElementToBeDisplayed(consumersTopics);
            _driver.FindElement(consumersTopics).Click();
            Thread.Sleep(5000);
            driverWait.WaitForElementToBeDisplayed(pharmaAndHealthcare);
            _driver.FindElement(pharmaAndHealthcare).Click();
        }

        public void SaveArticle()
        {
            driverWait.WaitForElementToBeDisplayed(saveArticleBtn);
            _driver.FindElement(saveArticleBtn).Click();
            driverWait.WaitForElementToBeDisplayed(folderName);
            _driver.FindElement(folderName).SendKeys("test");
            Thread.Sleep(5000);
            _driver.FindElement(createBtn).Click();
        }

        public void ClickPdfBtn()
        {
            _driver.FindElement(pdfBtn).Click();
        }

        public void SwitchToTopics()
        {
            _helperClass.SwitchToTab2("/topics");
        }
        public void ClickBrandPrdt()
        {
            Thread.Sleep(5000);
            _driver.FindElement(brandPrdtLaunch).Click();
        }
        public void CheckTopicFilter(string section)
        {
            Thread.Sleep(5000);
            var element = _driver.FindElement(moreFilterBtn);
            IJavaScriptExecutor j = (IJavaScriptExecutor)_driver;
            j.ExecuteScript("arguments[0].scrollIntoView({block: 'center', inline: 'nearest'})", element);
            Thread.Sleep(5000);
            driverWait.WaitForElementToBeDisplayed(moreFilterBtn);
            _driver.FindElement(moreFilterBtn).Click();
            VerifySearchFilter(section);
        }
        public void SwitchToCategories()
        {
            _helperClass.SwitchToTab2("/topics/categories");
        }
        public void ClickAlcoholicDrinks()
        {
            Thread.Sleep(5000);
            _driver.FindElement(alcoholicDrinks).Click();
        }

        public void SwitchToGeography()
        {
            _helperClass.SwitchToTab2("/topics/geographies");
        }
        public void ClickBenin()
        {
            Thread.Sleep(5000);
            _driver.FindElement(benin).Click();
        }
        public void SwitchToFeeds()
        {
            _helperClass.SwitchToTab2("/feed");
            
        }
        public bool VerifyCategoryFilter()
        {
            SelectElement select = new SelectElement(_driver.FindElement(By.Id("Category")));
            select.SelectByValue("Alcoholic drinks");
            driverWait.WaitForElementToBeDisplayed(alcoholicDrinksText);
            return _driver.FindElement(alcoholicDrinksText).Displayed;
        }
        public bool VerifyLocationFilter()
        {
            SelectElement select = new SelectElement(_driver.FindElement(By.Id("Location")));
            select.SelectByText("Argentina");
            driverWait.WaitForElementToBeDisplayed(argentinaText);
            return _driver.FindElement(argentinaText).Displayed;
        }
        public void ClickCmoStruggle()
        {
            driverWait.WaitForElementToBeDisplayed(cmoStruggleBtn);
             _driver.FindElement(cmoStruggleBtn).Click();
        }
        public bool CmoStruggleTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(cmoStruggleText);
            return _driver.FindElement(cmoStruggleText).Displayed;
        }
        public void SwitchToCasefinder()
        {
            _helperClass.SwitchToTab2("/casefinder");

        }
        public void ClickCategories()
        {
            driverWait.WaitForElementToBeDisplayed(categoriesBtn);
            _driver.FindElement(categoriesBtn).Click();
            
        }
        public void FindAlcoholicDrinkCases()
        {
            driverWait.WaitForElementToBeDisplayed(By.XPath("(//i[@class='jstree-icon jstree-checkbox'])[1]"));
            Actions action = new Actions(_driver);
            action.MoveToElement(_driver.FindElement(By.XPath("(//i[@class='jstree-icon jstree-checkbox'])[1]"))).Click().Perform();
            driverWait.WaitForElementToBeDisplayed(findCaseBtn);
            _driver.FindElement(findCaseBtn).Click();


        }
        public void SwitchToCaseStudies()
        {
            _helperClass.SwitchToTab2("/case-studies");

        }
        public void VerifyCaseContent(string section)

        {
            Thread.Sleep(10000);
            var elements = _driver.FindElements(By.XPath("//div[@class='tiles-triptych tiles-spaced']//p"));
            List<string> errors = new List<string>();

            foreach (var item in elements)
            {
                if (!item.Displayed)
                {
                    errors.Add(item.Text);

                }
            }
            if (errors.Any())
                throw new Exception($"The following errors were found : {string.Join(" ,", section)}");

        }
        public void SwitchToPartnerAwards()
        {
            _helperClass.SwitchToTab2("/partner-awards");
        }
        public bool PartnerTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(partnerAwardsText);
            return _driver.FindElement(partnerAwardsText).Displayed;
        }

        public void SwitchToWarcGuide()
        {
            _helperClass.SwitchToTab2("/warc-guide");
        }

        public void ClickWarcGuide()
        {
            driverWait.WaitForElementToBeDisplayed(viewWarcGuideBtn);
            var element = _driver.FindElement(viewWarcGuideBtn);
            Thread.Sleep(5000);
            element.Click();
        }
        public bool WarcGuideTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(fullWarcGuideTxt);
            return _driver.FindElement(fullWarcGuideTxt).Displayed;
        }

        public void SwitchToWarcTalks()
        {
            _helperClass.SwitchToTab2("/warctalks");
        }
        public void ClickPodcast()
        {
            driverWait.WaitForElementToBeDisplayed(podcastBtn);
            _driver.FindElement(podcastBtn).Click();
        }
        public bool PodcastCurrentTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(podcastCurrentText);
            return _driver.FindElement(podcastCurrentText).Displayed;
        }
        public void ClickWebinar()
        {
            driverWait.WaitForElementToBeDisplayed(webinarBtn);
            _driver.FindElement(podcastBtn).Click();

        }
        public bool LastestWebinarTextIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(lastestWebinarsText);
            return _driver.FindElement(lastestWebinarsText).Displayed;
        }
        public void SwitchToBestPractice()
        {
            _helperClass.SwitchToTab2("/reports/best-practice#wwi");
        }
        public void ClickWhatWeknw()
        {
            driverWait.WaitForElementToBeDisplayed(whatWeKnowText);
            _driver.FindElement(whatWeKnowText).Click();
        }
        public bool ClickWhatWeknwIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(whatWeKnow);
            return _driver.FindElement(whatWeKnow).Displayed;
        }
        public void ClickWhatsWorkingIn()
        {
            driverWait.WaitForElementToBeDisplayed(whatsWorkingIn);
            _driver.FindElement(whatsWorkingIn).Click();
        }
        public bool WhatsWorkingIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(whatsWorkingInTxt);
            return _driver.FindElement(whatsWorkingIn).Displayed;
        }
        public void SwitchToResearchPage()
        {
            _helperClass.SwitchToTab2("/research");
        }

        public void ReasearchList()
        {
            var element = _driver.FindElements(reasearchList);
            
            List<string> error= new List<string>();
            for (int i = 0; i < element.Count; i++)
            {
                
                if (element.Count!=9)
                {
                    error.Add(element.ElementAt(i).Text);
                }
            }

        }

        public void ClickJournalWebsite()
        {
            var element = _driver.FindElement(journalWebsite);
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
            element.Click();
        }
        public bool JournalAdvertisingLoginIsDisplayed()
        {
            driverWait.WaitForElementToBeDisplayed(journalLogin);
            return _driver.FindElement(journalLogin).Displayed;
        }
        public void SwitchToStrategyToolkitPage()
        {
            _helperClass.SwitchToTab2("/strategy-toolkit");
        }

        public bool ModulesMarketingStrategyList()
        {
            Thread.Sleep(5000);
            var element = _driver.FindElements(strategyModules);

            List<string> error = new List<string>();
            for (int i = 0; i < element.Count; i++)
            {

                if (element.Count != 8)
                {
                    error.Add(element.ElementAt(i).Text);
                }
            }
            return element.Count > 0;

        }
        public void SwitchToFutureStrategyPage()
        {
            _helperClass.SwitchToTab2("/future-of-strategy");
        }

        public bool FutureStrategyTxt()
        {
            Thread.Sleep(5000);
            var element = _driver.FindElements(strategyTxt);

            List<string> error = new List<string>();
            for (int i = 0; i < element.Count; i++)
            {

                if (element.Count != 3)
                {
                    error.Add(element.ElementAt(i).Text);
                }
            }
            return element.Count > 0;

        }
        public void SwitchToPitchSupportPage()
        {
            _helperClass.SwitchToTab2("/pitch-support");
        }

        public void ClickPitchBuilder()
        {
            _driver.FindElement(PitchBuilder).Click();
        }
        public bool PitchBuilderTextIsDisplayed()
        {
            Thread.Sleep(5000);
            driverWait.WaitForElementToBeDisplayed(pitchBuilderTxt);
            return _driver.FindElement(pitchBuilderTxt).Displayed;
        }
        public void ClickNewBusinessGuide()
        {
            _helperClass.SwitchToTab2("/pitch-support");
        }

    }
     
    }

