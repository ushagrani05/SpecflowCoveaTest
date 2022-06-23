Feature: Invalidemailaddress

A short summary of the feature

@Invalidemail
Scenario: A invalid email address is entered
   Given I am at the user quote pagee
   When  I fill the invalid "emailaddress" textbox as "usha./*$/@ggss.com"
   And   Errormessage should be displayedd



