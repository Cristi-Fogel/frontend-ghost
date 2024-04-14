using frontend.Constants;
using frontend.PageObjects;

namespace frontend.Tests
{   
    public class PracticeTest : BaseSelenium
    {
        //navigation to desired URL handled within BaseClass, test will be open on that page
        [Test]
        public void ExecutePracticeTest()
        {   
            //define search therm
            string searchTerm = jsonReader.ExtractDataFromJson()["testData"]["searchTherm"].ToString();
            string teamSliderValue = jsonReader.ExtractDataFromJson()["testData"]["teamSliderValue"].ToString();

            //search
            HeaderPageObjects headerObjects = new HeaderPageObjects(Driver);
            headerObjects.navigateToResources();

            ResourcesPageObjects resourcesPage = new ResourcesPageObjects(Driver);
            resourcesPage.searchForResult(searchTerm);
            
                //this part can definetly be improved and marged within resourcesPage
            ResourcesSearchResultsPageObjects searchResults = new ResourcesSearchResultsPageObjects(Driver);
            searchResults.ClickOn10th();
            
            ScrollToTop();

            headerObjects.navigateToPricing();

            PricingPageObjects pricingPageObjects = new PricingPageObjects(Driver);
            pricingPageObjects.SelectAudienceValue(teamSliderValue);
             

            // // TODO:               
            // Assert.That(pricingPageObjects.GetStarterValuePrice().Text, Is.EqualTo("15"));
            // Assert.That(pricingPageObjects.GetCreatorValuePrice().Text, Is.EqualTo("1,065"));
            // Assert.That(pricingPageObjects.GetTeamValuePrice().Text, Is.EqualTo("1,315"));
            // Assert.That(pricingPageObjects.GetBusinessValuePrice().Text, Is.EqualTo("1,565"));                
        } 
        
    }
}
