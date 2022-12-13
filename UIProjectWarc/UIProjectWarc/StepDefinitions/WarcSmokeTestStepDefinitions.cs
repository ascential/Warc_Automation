using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIProjectWarc.Pages;
using NUnit.Framework;
[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace UIProjectWarc.StepDefinitions
{
    [Binding]
    public class WarcSmokeTestStepDefinitions
    {

        private WarcSmokeTestPage warcSmokeTestPage;

        public WarcSmokeTestStepDefinitions(IWebDriver driver)
        {
            warcSmokeTestPage = new WarcSmokeTestPage(driver);
        }
        [Then(@"the menu items is displayed")]
        public void ThenTheMenuItemsIsDisplayed()
        {
            warcSmokeTestPage.MenuItemIsDisplayed();
            warcSmokeTestPage.ClickCancel();
        }
        [When(@"i click on find out more")]
        public void WhenIClickOnFindOutMore()
        {
            warcSmokeTestPage.ClickFindMore();
        }

        [Then(@"The WARC Consumer trends Report Coping in an era of serial crises is displayed")]
        public void ThenTheWARCConsumerTrendsReportCopingInAnEraOfSerialCrisesIsDisplayed()
        {
            warcSmokeTestPage.FindMoreTextIsDisplayed();
        }
        [When(@"i click on the signup link")]
        public void WhenIClickOnTheSignupLink()
        {
            warcSmokeTestPage.ClickSignup();
        }

        [Then(@"Sign up for our free daily newsletter is displayed")]
        public void ThenSignUpForOurFreeDailyNewsletterIsDisplayed()
        {
            warcSmokeTestPage.SignupTextIsDisplayed();
        }
        [When(@"i click on the contactus link")]
        public void WhenIClickOnTheContactusLink()
        {
            warcSmokeTestPage.ClickContactup();
        }

        [Then(@"We’d love to hear from you is displayed")]
        public void ThenWeDLoveToHearFromYouIsDisplayed()
        {
            warcSmokeTestPage.ContactUsTextIsDisplayed();
        }
        [When(@"i click on the GetADemo link")]
        public void WhenIClickOnTheGetADemoLink()
        {
            warcSmokeTestPage.ClickGetADemo();
        }
        [Then(@"Schedule your live demo with our team today is displayed")]
        public void ThenScheduleYourLiveDemoWithOurTeamTodayIsDisplayed()
        {
            Assert.True(warcSmokeTestPage.GetADemoIsDisplayed());
        }
        [When(@"i click on compare plans link")]
        public void WhenIClickOnComparePlansLink()
        {
            warcSmokeTestPage.ClickComparePlans();
        }

        [Then(@"Choose the plan that’s right for you is displayed")]
        public void ThenChooseThePlanThatSRightForYouIsDisplayed()
        {
            Assert.True(warcSmokeTestPage.ComparePlansTextIsDisplayed());
        }
        [When(@"i enter ""([^""]*)""")]
        public void WhenIEnter(string alcohol)
        {
            warcSmokeTestPage.SearchBoxField(alcohol);
        }

        [Then(@"the paywalled content is displayed")]
        public void ThenThePaywalledContentIsDisplayed()
        {
            Assert.True(warcSmokeTestPage.PaywallContentIsDisplayed());
        }
        [When(@"i scroll down the page")]
        public void WhenIScrollDownThePage()
        {
            warcSmokeTestPage.ScrollToSocialMediaFooter();
        }

        [When(@"I scroll down to the footer")]
        public void WhenIScrollDownToTheFooter()
        {
            warcSmokeTestPage.ScrollToBottomOfPage();
        }

        [Then(@"the links load correclty for")]
        public void ThenTheLinksLoadCorrecltyFor(Table table)
        {

            var sections = table.CreateInstance<string>();

        }

        [Then(@"all the links under '([^']*)' load correctly once clicked")]
        public void ThenAllTheLinksUnderLoadCorrectlyOnceClicked(string section)
        {
            warcSmokeTestPage.VerifyHomeFooterLinks(section);
        }



        [Then(@"the social media links appear in the footer")]
        public void ThenTheSocialMediaLinksAppearInTheFooter()
        {
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed("Facebook"));
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed("Twitter"));
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed("LinkedIn"));
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed("YouTube"));
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed("Instagram"));

        }
        [Then(@"the social media links appear in as ""([^""]*)"",""([^""]*)"",""([^""]*)"", ""([^""]*)"",""([^""]*)""")]
        public void ThenTheSocialMediaLinksAppearInAs(string facebook, string twitter, string youtube, string instagram, string linkedIn)
        {
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed(facebook));
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed(twitter));
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed(linkedIn));
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed(youtube));
            Assert.True(warcSmokeTestPage.SocialMediaIsDisplayed(instagram));
        }
        [When(@"the below is displayed")]
        public void WhenTheBelowIsDisplayed(Table table)
        {
            var Links = table.CreateInstance<WarcFooterLinks>();
            warcSmokeTestPage.VerifyHomeFooterLinks(Links);
            //warcSmokeTestPage.VerifyHomeLinksText(Links);
        }

        [Then(@"verify the recommended item is displayed '([^']*)'")]
        public void ThenVerifyTheRecommendedItemIsDisplayed(string recommendedItems)
        {
            var textIsPresent = warcSmokeTestPage.VerifyRecommendedItems().Any(text => text.Equals(recommendedItems));
            Assert.IsTrue(textIsPresent);
        }

        [Then(@"verify the Trending item is displayed '([^']*)'")]
        public void ThenVerifyTheTrendingItemIsDisplayed(string trendingItem)
        {
            var textIsPresent = warcSmokeTestPage.VerifyRecommendedItems().Any(text => text.Equals(trendingItem));
            Assert.IsTrue(textIsPresent);
        }
        [When(@"i click to case finder")]
        public void WhenIClickToCaseFinder()
        {
            warcSmokeTestPage.ClickCaseFinder();
        }

        [Then(@"search for advertising effectiveness case studies is displayed")]
        public void ThenSearchForAdvertisingEffectivenessCaseStudiesIsDisplayed()
        {
            Assert.True(warcSmokeTestPage.VerifyCaseFinderText());
        }
        [When(@"i click askwarc link")]
        public void WhenIClickAskwarcLink()
        {
            warcSmokeTestPage.ClickAskWarc();
        }

        [Then(@"ask a question page is displayed")]
        public void ThenAskAQuestionPageIsDisplayed()
        {
            Assert.True(warcSmokeTestPage.VerifyAskQstnText());

        }

        [When(@"i click media link")]
        public void WhenIClickMediaLink()
        {
            warcSmokeTestPage.ClickMedia();
        }

        [Then(@"welcome to warc media is displayed")]
        public void ThenWelcomeToWarcMediaIsDisplayed()
        {
            Assert.True(warcSmokeTestPage.VerifyMediaText());
        }
        [When(@"I click on search icon")]
        public void WhenIClickOnSearchIcon()
        {
            warcSmokeTestPage.ClickSearchIcon();
        }

        [Then(@"'([^']*)' is displayed")]
        public void ThenIsDisplayed(string p0)
        {
            warcSmokeTestPage.VerifySearchFilter(p0);
        }
        [Then(@"choose '([^']*)' and verify SERP is displayedd")]
        public void ThenChooseAndVerifySERPIsDisplayedd(string topics)
        {
            warcSmokeTestPage.ClickOnFilter(topics);

        }
        [Then(@"Click article")]
        public void ThenClickArticle()
        {
            warcSmokeTestPage.TickConsumerTopics();
        }

        [Then(@"save article")]
        public void ThenSaveArticle()
        {
            warcSmokeTestPage.SaveArticle();
        }

        [Then(@"generate PDF")]
        public void ThenGeneratePDF()
        {
            warcSmokeTestPage.ClickPdfBtn();
        }
        [When(@"im on the topic page")]
        public void WhenImOnTheTopicPage()
        {
            warcSmokeTestPage.SwitchToTopics();
        }

        [When(@"i click on brands and prdt launches")]
        public void WhenIClickOnBrandsAndPrdtLaunches()
        {
            warcSmokeTestPage.ClickBrandPrdt();
        }
        [When(@"check filtering appear '([^']*)'>")]
        public void WhenCheckFilteringAppear(string p0)
        {
            warcSmokeTestPage.CheckTopicFilter(p0);
        }
       
            [When(@"im on the categories page")]
            public void WhenImOnTheCategoriesPage()
            {
            warcSmokeTestPage.SwitchToCategories(); 
            }

            [When(@"i click on alcoholics drink")]
            public void WhenIClickOnAlcoholicsDrink()
            {
            warcSmokeTestPage.ClickAlcoholicDrinks();
            }
        [When(@"im on the geography page")]
        public void WhenImOnTheGeographyPage()
        {
            warcSmokeTestPage.SwitchToGeography();  
        }
        [When(@"i click on benin")]
        public void WhenIClickOnBenin()
        {
            warcSmokeTestPage.ClickBenin();
        }
        [When(@"im on the feed page")]
        public void WhenImOnTheFeedPage()
        {
            warcSmokeTestPage.SwitchToFeeds();
        }
        [Then(@"i can filter item by category")]
        public void ThenICanFilterItemByCategory()
        {
            warcSmokeTestPage.VerifyCategoryFilter();
        }
        [Then(@"filter by location")]
        public void ThenFilterByLocation()
        {
            warcSmokeTestPage.VerifyLocationFilter();
        }
        [When(@"i click on CMOs struggle slide")]
        public void WhenIClickOnCMOsStruggleSlide()
        {
            warcSmokeTestPage.ClickCmoStruggle();
        }

        [Then(@"CMOs struggle to get to grips with data ethics is displayed")]
        public void ThenCMOsStruggleToGetToGripsWithDataEthicsIsDisplayed()
        {
           warcSmokeTestPage.CmoStruggleTextIsDisplayed();
        }
        [When(@"i navigate to casefinder")]
        public void WhenINavigateToCasefinder()
        {
            warcSmokeTestPage.SwitchToCasefinder();
        }
        [When(@"i click categories")]
        public void WhenIClickCategories()
        {
            warcSmokeTestPage.ClickCategories();
        }
        [When(@"i find alcoholic drinks cases")]
        public void WhenIFindAlcoholicDrinksCases()
        {
            warcSmokeTestPage.FindAlcoholicDrinkCases();    
        }
        [When(@"im on the case study page")]
        public void WhenImOnTheCaseStudyPage()
        {
            warcSmokeTestPage.SwitchToCaseStudies();
        }

        [Then(@"the case '([^']*)' is displayed")]
        public void ThenTheCaseIsDisplayed(string p0)
        {
            warcSmokeTestPage.VerifyCaseContent(p0);
        }
        [When(@"im on the partner case studies")]
        public void WhenImOnThePartnerCaseStudies()
        {
            warcSmokeTestPage.SwitchToPartnerAwards();
        }

        [Then(@"the partner award case studies is displayed")]
        public void ThenThePartnerAwardCaseStudiesIsDisplayed()
        {
            warcSmokeTestPage.PartnerTextIsDisplayed();
        }

        [When(@"im on the warc guide")]
        public void WhenImOnTheWarcGuide()
        {
            warcSmokeTestPage.SwitchToWarcGuide();
        }

        [When(@"i click view all guides")]
        public void WhenIClickViewAllGuides()
        {
            warcSmokeTestPage.ClickWarcGuide();
        }

        [Then(@"full warc guide text is displayed")]
        public void ThenFullWarcGuideTextIsDisplayed()
        {
            warcSmokeTestPage.WarcGuideTextIsDisplayed();
        }
        [When(@"im on the warc talkspage")]
        public void WhenImOnTheWarcTalkspage()
        {
            warcSmokeTestPage.SwitchToWarcTalks();
        }

        [When(@"i click on podcast")]
        public void WhenIClickOnPodcast()
        {
            warcSmokeTestPage.ClickPodcast();
        }

        [Then(@"current episodes text is displayed")]
        public void ThenCurrentEpisodesTextIsDisplayed()
        {
            warcSmokeTestPage.PodcastCurrentTextIsDisplayed();
        }

        [Then(@"i click on webinars")]
        public void ThenIClickOnWebinars()
        {
            warcSmokeTestPage.ClickWebinar();   
        }

        [Then(@"lastest webinars is displayed")]
        public void ThenLastestWebinarsIsDisplayed()
        {
            warcSmokeTestPage.LastestWebinarTextIsDisplayed();  
        }
        [When(@"im on the best practice page")]
        public void WhenImOnTheBestPracticePage()
        {
            warcSmokeTestPage.SwitchToBestPractice();
        }

        [When(@"i click on what we know about")]
        public void WhenIClickOnWhatWeKnowAbout()
        {
            warcSmokeTestPage.ClickWhatWeknw();
        }

        [Then(@"warcs series of what we know about is displayed")]
        public void ThenWarcsSeriesOfWhatWeKnowAboutIsDisplayed()
        {
            warcSmokeTestPage.ClickWhatWeknwIsDisplayed();
        }

        [Then(@"i click on whats working in")]
        public void ThenIClickOnWhatsWorkingIn()
        {
            warcSmokeTestPage.ClickWhatsWorkingIn();
        }

        [Then(@"all report are displayed")]
        public void ThenAllReportAreDisplayed()
        {
            warcSmokeTestPage.WhatsWorkingIsDisplayed();
        }
        [When(@"im on warc research page")]
        public void WhenImOnWarcResearchPage()
        {
            warcSmokeTestPage.SwitchToResearchPage();
        }

        [Then(@"WARC Research content items are displayed\.")]
        public void ThenWARCResearchContentItemsAreDisplayed_()
        {
            warcSmokeTestPage.ReasearchList();
        }

        [Then(@"Reference link to Journal of Advertising Research is displayed")]
        public void ThenReferenceLinkToJournalOfAdvertisingResearchIsDisplayed()
        {
            warcSmokeTestPage.ClickJournalWebsite();
            Assert.True(warcSmokeTestPage.JournalAdvertisingLoginIsDisplayed());
        }

        [When(@"im on the strategy-toolkit")]
        public void WhenImOnTheStrategy_Toolkit()
        {
            warcSmokeTestPage.SwitchToStrategyToolkitPage();
        }

        [Then(@"the various modules of marketing strategy appears")]
        public void ThenTheVariousModulesOfMarketingStrategyAppears()
        {
            Assert.True(warcSmokeTestPage.ModulesMarketingStrategyList());
        }

        [When(@"im on the future of strategy")]
        public void WhenImOnTheFutureOfStrategy()
        {
            warcSmokeTestPage.SwitchToFutureStrategyPage();
        }

        [Then(@"the lastest report strategist interviews text are displayed")]
        public void ThenTheLastestReportStrategistInterviewsTextAreDisplayed()
        {
            Assert.True(warcSmokeTestPage.FutureStrategyTxt());
        }

    }

}

