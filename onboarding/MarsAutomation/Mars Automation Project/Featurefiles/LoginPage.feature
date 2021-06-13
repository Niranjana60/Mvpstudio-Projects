﻿Feature: LoginPage
	User is able to successfully Login with valid credentials

@automated
Scenario Outline: user is able to do Login succesfully with valid credentials
	Given I am in the login page at "http://localhost:5000"
	When I click the Sign In button
	And I enter <Email address> and <Password>
	When I click the Login button
	Then I should be logged in successfully
Examples: 	
    |Email address|Password|
    |pepparoy@gmail.com|Peppa@2021|