using OpenQA.Selenium;

namespace frontend.PageObjects
{
    public class HeaderPageObjects
    {
        private IWebDriver _driver;
        private IWebElement resourcesButton; 
        private IWebElement dropdownStartHereOption;
        private By pricingButtonLocator = By.CssSelector("body > div:nth-child(1) > header:nth-child(1) > div:nth-child(1) > div:nth-child(1) > nav:nth-child(3) > a:nth-child(4)");

        public HeaderPageObjects(IWebDriver driver)
        {
            _driver = driver; 
            resourcesButton = _driver.FindElement(By.CssSelector("body > div:nth-child(1) > header:nth-child(1) > div:nth-child(1) > div:nth-child(1) > nav:nth-child(3) > div:nth-child(3) > button:nth-child(1) > span:nth-child(1)"));
            dropdownStartHereOption = _driver.FindElement(By.CssSelector("body > div:nth-child(1) > header:nth-child(1) > div:nth-child(1) > div:nth-child(1) > nav:nth-child(3) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > a:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > p:nth-child(2)"));
        }

        public void navigateToResources()
        { 
            GetResourcesButton().Click(); 
            GetDropdownStartHereOption().Click();
        }

        public void navigateToPricing()
        {
            // Find the pricing button again to avoid stale element reference exception
            IWebElement pricingButton = _driver.FindElement(pricingButtonLocator);
            pricingButton.Click();
        }

        public IWebElement GetResourcesButton()
        {
            return resourcesButton;
        } 
 
        public IWebElement GetDropdownStartHereOption()
        {
            return dropdownStartHereOption;
        } 
    }
}
