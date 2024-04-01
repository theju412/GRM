using OpenQA.Selenium;
using System;
using System.Threading;

namespace GRMAutomation.Utilities
{
    public class Calender
    {
        //public IWebDriver driver;
       
        //[SetUp]
        //public void LauchingBrowser()
        //{
        //    driver = BaseSetUpClass.LaunchingTheBrowserAndOpeningSafesendURL();

        //}

        //[Test]
        public static void CalenderTest(IWebDriver driver, string enterDate, IWebElement backButton, IWebElement forwardButton, IWebElement monthYearisDisplayed, IWebElement dayToBeSelected)
        {
            Thread.Sleep(2000);
            
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            DateTime dateToBeSelected = Convert.ToDateTime(enterDate);
            
            string month = dateToBeSelected.ToString("MMMM");
            string day = dateToBeSelected.ToString("dd");
            string year = dateToBeSelected.ToString("yyyy");
            
            string monthYearToBeSelected = month + " " + year;
           

            IWebElement monthYearDisplayed = monthYearisDisplayed;
            
            while (!monthYearDisplayed.Text.Equals(monthYearToBeSelected))
            {
                if (currentDate.CompareTo(dateToBeSelected) == 1)
                {
                    backButton.Click();
                    
                    Thread.Sleep(2000);

                }
                else if (currentDate.CompareTo(dateToBeSelected) == -1)
                {
                    forwardButton.Click();
                    Thread.Sleep(2000);
                    

                }
                monthYearDisplayed = monthYearisDisplayed;

            }
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//a[text()=" + day + "]")).Click();         
            

        }

        //[TearDown]
        //public void ClosingBrowser()
        //{
        //    BaseSetUpClass.CloseBrowser();
        //}

    }
}
