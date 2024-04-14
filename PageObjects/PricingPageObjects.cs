using OpenQA.Selenium;

namespace frontend.PageObjects
{
    public class PricingPageObjects
    {
        private IWebDriver _driver;
        private IWebElement membersSlider;  
        private IWebElement starterValuePrice;
        private IWebElement creatorValuePrice;
        private IWebElement teamValuePrice;
        private IWebElement businessValuePrice;

        public PricingPageObjects(IWebDriver driver)
        {
            _driver = driver; 
            membersSlider = _driver.FindElement(By.Id("members"));
            starterValuePrice = _driver.FindElement(By.CssSelector(".text-5xl.font-bold.tracking-tight.text-gray-400"));
        } 
 

        public void SelectAudienceValue(string targetBackgroundSize)
        { 
            // Execute JavaScript to set the background size style property
            ((IJavaScriptExecutor)_driver).ExecuteScript($"arguments[0].style.backgroundSize = '{targetBackgroundSize} 100%';", membersSlider);
        }

        public IWebElement GetMembersSlider()
        {
            return membersSlider;
        } 

        public IWebElement GetStarterValuePrice(){
            return starterValuePrice;
        }
           public IWebElement GetCreatorValuePrice(){
            return creatorValuePrice;
        }
           public IWebElement GetTeamValuePrice(){
            return teamValuePrice;
        }
           public IWebElement GetBusinessValuePrice(){
            return businessValuePrice;
        }

    }
}
