Feature: DataDrivenWithParameter
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameterization
	Given I navigate to "https://angularjs.realworld.io/#/register"
	And I click sign up 
	And I enter my Username "demo44"
	And I enter my email "learn"
	And I enter my password "PasswordSecure"
	When I click on sign button
	#Then I should be able to register


    Given I navigate to "https://angularjs.realworld.io/#/register"
	And I click sign up 
	And I enter my Username "selo44"
	And I enter my email "finland"
	And I enter my password "PasswordSecure"
	When I click on sign button

	Given I navigate to "https://angularjs.realworld.io/#/register"
	And I click sign up 
	And I enter my Username "wisky44"
	And I enter my email "syrety"
	And I enter my password "PasswordSecure"
	When I click on sign button