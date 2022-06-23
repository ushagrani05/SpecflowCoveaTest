Feature: CompletedForm

A short summary of the feature

@completedquoteform
Scenario: complete all sections from quote form
	Given I am at userr quote page
	When I enter  firstname
	And I enter lastname
	And  I enter contactnumber
	And  I enter postcodee
	And I click continue with valid information
	Then summarypage is displayed
