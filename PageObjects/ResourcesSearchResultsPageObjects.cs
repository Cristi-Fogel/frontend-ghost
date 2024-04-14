using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace frontend.PageObjects
{
    public class ResourcesSearchResultsPageObjects
    {
        private IWebDriver _driver;
        private By searchResults10thLocator = By.CssSelector("li:nth-child(10) a");

        public ResourcesSearchResultsPageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickOn10th()
        { 
            // Retry clicking on the 10th element a few times to handle StaleElementReferenceException
            int attempts = 0;
            while (attempts < 3)
            {
                try
                {
                    // Find the element again to avoid stale element reference exception
                    IWebElement searchResults10thElement = _driver.FindElement(searchResults10thLocator);
                    searchResults10thElement.Click();
                    return; // Exit the method if click is successful
                }
                catch (StaleElementReferenceException)
                {
                    // Increment attempts and wait a bit before retrying
                    attempts++;
                    System.Threading.Thread.Sleep(1000);
                }
            }
            // If all attempts fail, throw the exception
            throw new StaleElementReferenceException("Failed to click on the 10th element after multiple attempts.");
        }
    }
}
