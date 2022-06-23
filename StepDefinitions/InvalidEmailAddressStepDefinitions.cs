using System;
using TechTalk.SpecFlow;

namespace SpecflowCoveaTest.StepDefinitions
{
    [Binding]
    public class InvalidEmailAddressStepDefinitions
    {
        [Given(@"I am at the user quote pagee")]
        public void GivenIAmAtTheUserQuotePage()
        {
            Console.WriteLine("");
        }

        [When(@"I fill the invalid ""([^""]*)"" textbox as ""([^""]*)""")]
        public void WhenIFillTheInvalidTextboxAs(string emailaddress,string p1)
        {
            Console.WriteLine("Entering in" + emailaddress);
        }

        [When(@"Errormessage should be displayedd")]
        public void WhenErrormessageShouldBeDisplayed()
        {
        
            Console.WriteLine("Emailaddress is invalid");
        }

        [Then(@"I should be at the homepage")]
        public void ThenIShouldBeAtTheHomepage()
        {
            Console.WriteLine("");
        }
    }
}
