Feature: LogIn

This is to test the log in feature. 

@Login
Scenario: Login user as Administrator
	Given I navigate to applications
	And I click the log in link
	And I enter user usnername and password
	    | UserName | Password |
	    | admin    | password |
	And I click Login
	Then I should see user logged in to the applications
