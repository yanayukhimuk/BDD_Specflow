Feature: LoginFeature
	Login to EA Demo application

@yana_yukhimuk
Scenario: Perform Login of Mail.ru site
#steps 
	Given I launch the website 
	And I enter email
	| EmailAddress |
	| jane.black@internet.ru         |  
	And I  enter password
	 | Password |
	 |   CatAndDogs1999       |
	Then I should see the New Letter button
	