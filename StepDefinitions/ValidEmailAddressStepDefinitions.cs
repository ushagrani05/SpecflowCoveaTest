using System;
using TechTalk.SpecFlow;

namespace SpecflowCoveaTest.StepDefinitions
{
    [Binding]
    public class ValidEmailAddressStepDefinitions
    {
        [Given(@"I am at the user quote page")]
        public void GivenIAmAtTheUserQuotePage()
        {
            Console.WriteLine("");
        }

        [When(@"I fill the valid ""([^""]*)"" textbox as ""([^""]*)""")]
        public void WhenIFillTheValidTextboxAs(string emailaddress, string p1)
        {
            Console.WriteLine("Entering in" + emailaddress);
        }

        [When(@"message should not be displayed")]
        public void WhenMessageShouldNotBeDisplayed()
        {
        }

        [Then(@"I should be at homepage")]
        public void ThenIShouldBeAtHomepage()
        {
        }



    }
}
