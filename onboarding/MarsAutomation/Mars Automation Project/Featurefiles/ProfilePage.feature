Feature: Profile Page
         As a seller I want to add my details in profile.
		 I am also able to view my profile details

@automated
Scenario Outline: I am able to add my Language details
	Given I am logged in at "http://localhost:5000" as user "pepparoy@gmail.com" with password "Peppa@2021"
	And I am at the Profile page
	When I click on Add New button
	And I Add <Language> and <Language Level> on Languages tab
	And I click on Add button
	Then Validate that <Language> and <Language Level> are added

	Examples:
		| Language | Language Level   |
		| English  | Fluent           |
		| Irish    | Native/Bilingual |
		                        
@automated
Scenario Outline:I am able to add my skill details
	Given I am logged in at "http://localhost:5000" as user "pepparoy@gmail.com" with password "Peppa@2021"
	And I am at the Profile page
	And I click on Skills tab
	When I click on Add New button below Skills tab
	And I Add <Skill> and <Skill Level> on Skills tab
	And I click on Add button
	Then Validate that <Skill> and <Skill Level> are added.

	Examples:
		| Skill | Skill Level |
		| C     | Beginner    |
		| Java  | Expert      |		


@To be automated
Scenario:I am able to enter Description
	Given I am logged in at "http://localhost:5000" as user "pepparoy@gmail.com" with password "Peppa@2021"
	And I click on Description editter
	When I add the Description in description box
	And I click the save button
	Then the description should be saved and displayed under Description
	And success message is displayed

@To be automated
Scenario:Error message displayed if description box is blank
	Given I am logged in at "http://localhost:5000" as user "pepparoy@gmail.com" with password "Peppa@2021"
	And I am at the Profile Page
	And I click on Description editter
	When I don't add text in Description box
	And I click the save button
	Then the notification to add description should be displayed

@To be automated
Scenario:I am able to enter upto 600 characters in Description  box
	Given I am logged in at "http://localhost:5000" as user "pepparoy@gmail.com" with password "Peppa@2021"
	And I am at the Profile Page
	And I click on Description editter
	When I add upto 600 characters
	And I click the savebutton
	Then the description should be saved

@To be automated
Scenario:I am not able to enter more than 600 characters in Description  box
	Given I am logged in at "http://localhost:5000" as user "pepparoy@gmail.com" with password "Peppa@2021"
	And I am at the Profile Page
	And I click on Description editter
	When I add upto 600 characters
	And I am again adding characters in description box
	Then I am not able to enter anymore characters

@To be automated
Scenario:I am not able to add language if cancel button is clicked
	Given I am at the Profile Page
	When I click  Add New
	And I Add 'Language'
	And I choose 'Language Level'
	And I click 'Cancel'
	Then the Language should not be added

@To be automated
Scenario:I am not able to add languages after 4 selection
	Given I am at the Profile Page
	When I click on Languages
	When I has 4 languages in Language list
	Then Add new button should not be present to add any more Languages

@To be automated
Scenario:Unable to add language by simply clicking Add button
	Given I am at the Profile Page
	And I click on 'Languages'
	When I click  'Add New' button
	And I don't select any Language
	And I don't  select any Language Level
	And I click 'Add' button
	Then Error message displayed to Add Language add choose Language Level

@To be automated
Scenario:The text box to enter language should disppear when cancel button is clicked
	Given I am at the Profile Page
	And I click on 'Languages' tab
	When I click  'Add New' button
	And I don't select any Language
	And I don't  select any Language Level
	And I click cancel button
	Then The text box to Add language and choose Language level should disppear

@To be automated
Scenario:I should not be able to Add skills after cancel button is clicked
	Given I am logged in
	And I click on 'skills' tab
	When I click  'Add New' button
	And I 'Add' a new skill
	And I choose 'skill level' from drop down
	And I click 'cancel'
	Then no skill should be added

@To be automated
Scenario:I am able to Add Education
	Given I am logged in
	When I click on 'Education'
	And I click on Add New button
	And I Add my education details in all the fields
	And I click on 'ADD' button
	Then My Education details should be added
	And the success message is displayed

@To be automated
Scenario:I am not able to Add Education without entering all fields
	Given I am logged in
	When I click on 'Education'
	And I click on Add New button
	And I am not entering education details in all the fields
	And I click on 'ADD 'button
	Then Education details should not be added
	And error message is displayed

@To be automated
Scenario:I am able to Add Certifications
	Given I am logged in
	When I click on 'Certification'
	And I click on Add New button
	And I Add my certification details in all the fields
	And I click on 'ADD' button
	Then My Certification details should be added
	And the success message is displayed