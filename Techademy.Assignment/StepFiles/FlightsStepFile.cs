using System;
using System.Collections.Generic;
using System.Text;
using Techademy.Assignment.Pages;
using Techademy.Assignment.Utility;
using TechTalk.SpecFlow;

namespace Techademy.Assignment.StepFiles
{

    [Binding]
    class FlightsStepFile
    {

        
        FlightPage flightPage = new FlightPage();
        private ReusableMethods reusableMethods = new ReusableMethods();
        TestData testData = TestData.getInstance();

        [Given(@"airasia website is launched successfully")]
        public void GivenAirasiaWebsiteIsLaunchedSuccessfully()
        {
            flightPage.launchUrl(testData.Url);
            LogFile.LogInformation("Air Asia url is launched");

        }

        [Given(@"verify the home page title")]
        public void GivenVerifyTheHomePageTitle()
        {

        }

        [Given(@"enter From as ""(.*)""")]
        public void GivenEnterOriginAs(string fromPlace)
        {
            
        }

        [Given(@"enter To as ""(.*)""")]
        public void GivenEnterToAs(string toPlace)
        {
           
        }


        [Given(@"enter departure date as ""(.*)""")]
        public void GivenEnterDepartureDateAs(string departureDate)
        {
          
        }

        [Given(@"enter return date as ""(.*)""")]
        public void GivenEnterReturnDateAs(string returnDate)
        {
          
        }

        [Given(@"select return as ""(.*)""")]
        public void GivenSelectReturnAs(string returnType)
        {
            
        }

        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            
        }

        [Then(@"Verify flight search results page is displayed")]
        public void ThenVerifyFlightSearchResultsPageIsDisplayed()
        {
         
        }

    }
}
