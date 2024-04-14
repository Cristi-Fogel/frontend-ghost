using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Safari; 
using frontend.PageObjects;
using frontend.Constants;
using frontend.Utilities;



namespace frontend.Tests
{
    public class BaseSelenium
    {
        private IWebDriver _driver;
        protected JsonReader jsonReader;
        
        //defined as such so we use the reference and not alter it directly 
        public IWebDriver getDriver(){
            return _driver;
        }
        protected IWebDriver Driver => _driver;

        [SetUp]
        public void Setup()
        {
            InitializeJsonReader();
            InitBrowser("Edge");
            _driver.Manage().Window.Maximize(); 
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Navigate().GoToUrl(BaseValues.environmentBaseUrl); //baseURL for 1st testing site
        }


        [TearDown]
        public void TearDown()
        {
            // _driver.Quit();
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    _driver = new FirefoxDriver();
                    break;
                case "Edge":
                    _driver = new EdgeDriver();
                    break;
                case "Safari":
                    _driver = new SafariDriver();
                    break;
                case "Chrome":
                    _driver = new ChromeDriver();
                    break;
            }
        
        }    

        private void InitializeJsonReader()
        {   
            jsonReader = new JsonReader();
            var jsonBody = jsonReader.ExtractDataFromJson();
            // reqresInValuesFromJson = jsonBody["reqresIn"]; //example if a certain json set is needed
        }

        public void ScrollToTop()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
        }

    }
}


 
//TODO: shift config json data to appconfig so all can be found in 1 place




// setup for crome driver:
// dotnet add package Selenium.WebDriver
// dotnet add package Selenium.WebDriver.ChromeDriver --version 87.0.4280.8800
// dotnet add package NUnit
// dotnet add package NUnit3TestAdapter
