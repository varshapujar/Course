using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Techademy.Assignment.Hooks;
using Techademy.Assignment.Utility;

namespace Techademy.Assignment.Pages
{
    class FlightPage
    {
        IWebDriver driver;
        private ReusableMethods reusableMethods = new ReusableMethods();
        public FlightPage()
        {
            driver = ReusableMethods.driver;
        }
        TestData inputDataFile = TestData.getInstance();

        protected IWebElement FlightBtn => driver.FindElement(By.XPath("//*[@alt='Flights']"));
        protected IWebElement homePageTitle => driver.FindElement(By.Id("las-logo"));
        protected IWebElement homePageLogo => driver.FindElement(By.XPath("//*[@alt='logo']"));
        protected IWebElement fromTxtBx => driver.FindElement(By.XPath("//*[@label='From']"));
        protected IWebElement fromValue => driver.FindElement(By.XPath("//div[contains(text(),'Bengaluru')]"));
        protected IWebElement toTxtBx => driver.FindElement(By.XPath("//*[@label='To']"));
        protected IWebElement toValue => driver.FindElement(By.XPath("//div[contains(text(),'Bengaluru')]"));
       


        public void launchUrl(string url)
        {
            reusableMethods.launchUrl(url);
            LogFile.LogInformation("Url is launched successfully");
            reusableMethods.WaitForPageToLoadComplete(10);
            verifyHomePage();
        }
        public void clickOnFlights()
        {
            bool a = reusableMethods.IsElementDisplayed(FlightBtn);
            if (a == true)
            {
                reusableMethods.ClickElement(FlightBtn);
                LogFile.LogInformation("Clicked on Flight button");
            }
            else
            {
                LogFile.LogInformation("Flight button is not displayed");
            }
        }

        public void verifyTitle()
        {
            String pageTitle = homePageTitle.Text;
            String title = driver.Title;
            LogFile.LogInformation("title of the page"+title);

        }

        public void verifyHomePage()
        {
            bool check = reusableMethods.IsElementDisplayed(homePageLogo);
            if(check == true)
            {
                LogFile.LogInformation("Home page is displayed");
            }
           
        }
       
        
    }
}
