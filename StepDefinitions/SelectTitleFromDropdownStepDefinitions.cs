using System;
using TechTalk.SpecFlow;

namespace SpecflowCoveaTest.StepDefinitions
{
    [Binding]
    public class SelectTitleFromDropdownStepDefinitions
    {
        [Given(@"I am at the quote page")]
        public void GivenIAmAtTheQuotePage()
        {
            Console.WriteLine("");
        }

        [When(@"I select dropdown")]
        public void WhenISelectDropdown()
        {
            Console.WriteLine("Selectedfromdropdown");
        }

        [Then(@"I select the title Mr")]
        public void ThenISelectTheTitleMr()
        {
            Console.WriteLine("TitleMr is selected from dropdown");
        }
    }
}
