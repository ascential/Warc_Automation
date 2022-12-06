#Feature: DemoPage
#Background: Ability to click on Get a demo on the header
#	Given Im a customer on Warc UI
#	When i click on “Get a demo” on the header
#	Then a data entry form is displayed.
#
#Scenario Outline: Fill data entry form with incorrect data
#	Given I enter the following data
#
#		| Firstname   | Lastname   | Phonenumber   | EmailAddress   | JobTitle   | CompanyName   | Town   | BusinessType   | Brand   |
#		| <Firstname> | <Lastname> | <Phonenumber> | <EmailAddress> | <JobTitle> | <CompanyName> | <Town> | <BusinessType> | <Brand> |
#    When i click the submit button
#	Then the error message '<ErrorMessage>' is displayed		
#
#Examples:
#| Firstname | Lastname | Phonenumber | EmailAddress  | JobTitle | CompanyName | Town       | BusinessType | Brand     | ErrorMessage                                                                                                                 |
#| jess      | jess     | 989898888   | test@test.com | test     | test        | test       | Brand        | Apparel   |                                                                                                                              |
#| lee       | lee      | 666788999   | test@test.com | test     | test        | test       | Media Agency | WPP-owned |                                                                                                                              |
#| top       | top      | 675543      | test@test.com | tet      | test        | test       | Brand        | Apparel   |                                                                                                                              |
#| teres     | teres    | 6546789     | test@test.com | test     | test        | test       | IPG-owned    |           |                                                                                                                              |  
#| lee       | dee      | 0767888321  | test@test.com | Test     | Warc        |            | Brand        | Apparel   | Please ensure you have entered a town/city                                                                                   |
#| ade       | dee      | 0767888321  | test@test.com | Test     |             | Manchester | Brand        | Apparel   | Please ensure you have entered a company name                                                                                |
#| tos       |          | 089999996   | test@test.com | Test     | warc        | London     | Brand        | Apparel   | Please ensure you have entered a last name                                                                                   |
#| test      | dee      |             | test@test.com | Test     | warc        | London     | Brand        | Apparel   | Please ensure you have entered a telephone number                                                                            |
#| love      | tee      | 089999996   |               | Test     | warc        | London     | Brand        | Apparel   | The email address entered is reported as not being valid or not a business email address, please use an alternative address. |
#
#
##Scenario: Fill data entry form with correct data
##	Given I enter the following data
##
##	    | Firstname   | Lastname   | Phonenumber   | EmailAddress   | JobTitle   | CompanyName   | Town   | BusinessType   | Brand   |
##		| <Firstname> | <Lastname> | <Phonenumber> | <EmailAddress> | <JobTitle> | <CompanyName> | <Town> | <BusinessType> | <Brand> |
##    When i click the submit button
#
