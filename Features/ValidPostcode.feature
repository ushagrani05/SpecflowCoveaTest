Feature: ValidPostcode

A short summary of the feature

@Validpostcode
Scenario: Postcode look for valid postcode
	Given I am at quote page
	When I enter firstname
	And I enter surname
	And Ienter contactnumber
	And I enter postcode
	And I click address
	Then I get list of address is displayed
