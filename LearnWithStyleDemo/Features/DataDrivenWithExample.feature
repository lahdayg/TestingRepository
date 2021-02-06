Feature: DataDrivenWithExample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Data Driven With Example
	Given I navigate to "https://angularjs.realworld.io/#/register"
	And I click sign up 
	And I enter my username "<Username>"
	And I enter my emailaddress "<Email>"
	And I enter my passwordtext "<Password>"
	#When I click on sign button


	Examples:

	| Username | Email          | Password       |
	| Kike     | kike@demo.com  | PasswordSecure |
	| Ade      | ade@demo.cm    | PasswordSecure |
	| Tyson    | tyson@demo.com | PasswordSecure |
