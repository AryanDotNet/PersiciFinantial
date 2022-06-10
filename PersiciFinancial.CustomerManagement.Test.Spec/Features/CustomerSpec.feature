Feature: CustomerSpec
In order to use the website 
as a customer
I want to able to register

Scenario: register new customer
	Given I have registered as following
	| Firstname | Lastname  | DateOfBirth | PhoneNumber | Email                   | BankAccountNumber |
	| Mohammad  | Aryanpour | 09/04/1987  | +989128907347 | aryanpour.dev@gmail.com | 202504060875      |
	When I register
	Then I should redirect to my profile

Scenario: register a customer with duplicate FirstName, LastName, BirthOfDate
	Given I have already registered in the web site as follwing
	| Firstname | Lastname  | DateOfBirth |
	| Mohammad  | Aryanpour | 09/04/1987  |
	And I'm going to register as following
	| Firstname | Lastname  | DateOfBirth | PhoneNumber | Email                   | BankAccountNumber |
	| Mohammad  | Aryanpour | 09/04/1987  | +989128907347 | aryanpour.dev@gmail.com | 202504060875      |
	When I register
	Then the system should warn me you have already registered

Scenario: register a customer with duplicate Email
	Given I have already registered in the web site with 'aryanpour.dev@gmail.com' email
	And I try to register as following
	| Firstname | Lastname  | DateOfBirth | PhoneNumber | Email                   | BankAccountNumber |
	| Mohammad  | Aryanpour | 09/04/1987  | +989128907347 | aryanpour.dev@gmail.com | 202504060875      |
	When I register
	Then the system should warn me the email is duplicated
	