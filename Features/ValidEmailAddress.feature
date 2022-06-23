Feature: ValidEmailAddress

@Validemail
Scenario: A valid email address is entered
 Given I am at the user quote page
 When I fill the valid "emailaddress" textbox as "usha@gmail.com"
 And message should not be displayed
 Then I should be at homepage


