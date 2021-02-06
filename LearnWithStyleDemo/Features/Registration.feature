Feature: Registration
	In order to use the website
	I will need to first register

@mytag
Scenario: Valid Registration
	Given I navigate to website
	And I click sign up button
	And I enter my Username
	And I enter my email
	And I enter my password
	When I click on sign up button
	Then I should be able to register