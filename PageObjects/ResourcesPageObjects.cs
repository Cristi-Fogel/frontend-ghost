using OpenQA.Selenium;

namespace frontend.PageObjects
{
    public class ResourcesPageObjects
    {
        private IWebDriver _driver;
        // Define your web elements
        private IWebElement searchInputField;  
        private IWebElement searchResults10thelement;
        
        // Constructor to initialize the page objects
        public ResourcesPageObjects(IWebDriver driver)
        {
            _driver = driver; 
            searchInputField = _driver.FindElement(By.CssSelector("#search-input"));
            // searchResults10thelement = _driver.FindElement(By.CssSelector("li:nth-child(10)"));
             
        }

        // Actions to interact with the page
        public void searchForResult(string searchTherm)
        { 
            GetSearchInputField().SendKeys(searchTherm);   

        }

        // Encapsulate your web elements 
        public IWebElement GetSearchInputField()
        {
            return searchInputField;
        } 
        // public IWebElement GetsearchResults10thelement()
        // {
        //     return searchResults10thelement;
        // } 

    }
}
