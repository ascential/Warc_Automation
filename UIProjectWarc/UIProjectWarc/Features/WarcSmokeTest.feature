Feature: WarcSmokeTest

A short summary of the feature

#Scenario: verify the links for find out more etc
#   Given Im a customer on Warc UI
#	When i click on find out more
#   Then The WARC Consumer trends Report Coping in an era of serial crises is displayed

#Scenario: verify the link for signup
#	Given Im a customer on Warc UI
#	When i click on the signup link
#   Then Sign up for our free daily newsletter is displayed
##
#Scenario: verify the link for contactus
#	Given Im a customer on Warc UI
#	When i click on the contactus link
#   Then We’d love to hear from you is displayed
#
#
#Scenario: verify the link for Get A demo
#	Given Im a customer on Warc UI
#	When i click on the GetADemo link
#   Then Schedule your live demo with our team today is displayed

#Scenario: verify the link for compare plans
#	Given Im a customer on Warc UI
#	When i click on compare plans link
#   Then Choose the plan that’s right for you is displayed
#
#Scenario: verify the search Box 
#	Given Im a customer on Warc UI
#	When i enter "alcohol"
#   Then the paywalled content is displayed
#
#Scenario:Check the social media links appear in the footer.
#	Given Im a customer on Warc UI
#	When i scroll down the page
#   Then the social media links appear in the footer
#
#Scenario Outline: Check each of the links under Home, ABOUT,SUPPORT and LEGAL in the footer lead to the desired pages.
#	Given Im a customer on Warc UI
#	When I scroll down to the footer
#	Then all the links under '<Sections>' load correctly once clicked
#
#	Examples: 
#	| Sections |
#	| Home     |
#
#Scenario Outline: Verify signIn has search bar, language and menu icon
#Given Im a customer on Warc UI
#When I enter my username and password
#
#Then verify the recommended item is displayed '<recommendedItem>'
#And verify the Trending item is displayed '<TrendingItem>'
#Examples: 
#| recommendedItem                                                | TrendingItems                                               |
#| Office For National Statistics: Census 2021                    | Global Ad Trends: The rising cost of incremental reach      |
#
#| Savlon: Surface disinfectant – Putting the fun in disinfection | Insights from the 2022 Creative Effectiveness Lions winners |
#
#Scenario:Check the link to  Case Finder and Ask Warc (WARC Plus) are present next to the Trending section.
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And i click to case finder
#   Then search for advertising effectiveness case studies is displayed
#
#   Scenario:Check the link to Ask Warc (WARC Plus) are present next to the Trending section.
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And i click askwarc link
#   Then ask a question page is displayed
# Scenario:Check the link to the media home page
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And i click media link
#   Then welcome to warc media is displayed
#
#   Scenario Outline:Check the following are displayed on search page
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	When I click on search icon
#	Then '<filter>' is displayed
#	Then choose 'Topics' and verify SERP is displayedd
#	And Click article
#	And save article
#	And generate PDF
#	
#	Examples: 
#	| filter        |
#	| search filter |
#
#	Scenario: Check Warc Topics
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And im on the topic page
#   And i click on brands and prdt launches
#   And check filtering appear '<filter'>
#
#   Examples: 
#	| filter        |
#	| search filter |
#
#Scenario: Check Warc Categories
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And im on the categories page
#   And i click on alcoholics drink
#   And check filtering appear '<filter'>
#
#   Examples: 
#	| filter        |
#	| search filter |
#
#
#Scenario: Check Warc Geography
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And im on the geography page
#   And i click on benin
#   And check filtering appear '<filter'>
#
#   Examples: 
#	| filter        |
#	| search filter |
#
#Scenario: Check Warc category
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And im on the feed page
#	Then i can filter item by category
#	And filter by location
#
#Scenario: Verify the content in the feed tile
#	Given Im a customer on Warc UI
#	When i navigate to casefinder
#	And i click categories
#	And i find alcoholic drinks cases
#	And check filtering appear '<filter'>
#
#   Examples: 
#	| filter        |
#	| search filter |

#Scenario: Check Warc campaign data
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And im on the case study page
#	Then the case '<content>' is displayed
#	
#	Examples: 
#	| content        |
#	| search filter |

#Scenario: Check Warc campaign data
#	Given Im a customer on Warc UI
#	When I enter my username and password
#	And im on the partner case studies
#	Then the partner award case studies is displayed

	#Scenario: Check Warc guide
	#Given Im a customer on Warc UI
	#When I enter my username and password
	#And im on the warc guide
	# And i click view all guides
	#Then full warc guide text is displayed

	#Scenario: Check Warc guide
	#Given Im a customer on Warc UI
	#When I enter my username and password
	#And im on the warc talkspage
	#And i click on podcast
	#Then current episodes text is displayed
	#And i click on webinars
	#Then lastest webinars is displayed
#
	#Scenario: Check Warc guide
	#Given Im a customer on Warc UI
	#When I enter my username and password
 #   And im on the best practice page
	#And i click on what we know about 
	#Then warcs series of what we know about is displayed
	#And i click on whats working in
	#Then all report are displayed

	#Scenario: check that tabs Podcast and Webinars appear on the page, in the tabs respectively individual podcasts and webinars are displayed.
	#Given Im a customer on Warc UI
	#When I enter my username and password
 #   And im on warc research page
	#Then WARC Research content items are displayed.
	#Then Reference link to Journal of Advertising Research is displayed
	# 
	#Scenario: Strategy toolkit 
	#Given Im a customer on Warc UI
	#When I enter my username and password
	#And im on the strategy-toolkit
	#Then the various modules of marketing strategy appears

	#Scenario: Future of strategy 
	#Given Im a customer on Warc UI
	#When I enter my username and password
	#And im on the future of strategy
	#Then the lastest report strategist interviews text are displayed
    
	Scenario: Pitch Support 
	Given Im a customer on Warc UI
	When I enter my username and password
	And im on pitch support page
	And i click on start the pitch builder
	Then i land on the pitch builder page
	When I click on new business guide
	#Then i land on the new business guide page

	
