using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using RelevantCodes.ExtentReports;
using GRMAutomation.Utilities;
using GRMAutomation.DataReader;
using System;
using System.Configuration;


namespace GRMAutomation.BaseSetUp
{
    public class BaseSetUpClass : TestBase
    {
        public string BrowserType { get; private set; }

        public static BaseSetUpClass Create()
        {
            return new BaseSetUpClass();
        }

        public string GRMurl { get; private set; }
        public string InstaURL { get; private set; }
        public string CreateCompanyURL { get; private set; }
        public string SignUpPageURL { get; private set; }


        //private readonly string pdfMimeType;
        //private readonly string rarMimeType;
        //private readonly string zipMimeType;
        //private readonly string csvMimeType;

        public BaseSetUpClass()
        {
            BrowserType = ExcelReaderHelper.GetCellData(fileLocation, "BrowserName", 1, 0).ToString();
            GRMurl = ExcelReaderHelper.GetCellData(fileLocation, "URL", 1, 1).ToString();            
            CreateCompanyURL = ExcelReaderHelper.GetCellData(fileLocation, "URL", 3, 1).ToString();
            SignUpPageURL = ExcelReaderHelper.GetCellData(fileLocation, "URL", 4, 1).ToString();

            //InstaGathering URL
            InstaURL = ExcelReaderHelper.GetCellData(fileLocation, "URL", 5, 1).ToString();

            //pdfMimeType = "application/pdf,application/x-pdf,";
            //rarMimeType = "application/x-rar-compressed, application/octet-stream,";
            //zipMimeType = "application/zip, application/octet-stream, application/x-zip-compressed, multipart/x-zip,";
            //csvMimeType = "application/csv, text/csv,";

        }

        //launch browser and enter GRM URL to proceed
        public  IWebDriver LaunchingTheBrowserAndOpeningGrmLoginPage()
        {
         
            switch(BrowserType)
            {
                case "Chrome":
                    ChromeOptions option = new ChromeOptions();
                    option.AddArguments("disable-infobars");
                    option.AddArgument("no-sandbox");
                    driver = new ChromeDriver(option);
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(GRMurl);
                    //driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
                    break;

                case "Firefox":
                    FirefoxProfile profile = new FirefoxProfile();
                    profile.SetPreference("browser.download.folderList", 2);
                    profile.SetPreference("browser.download.dir", "C:\\Windows\\temp");
                    profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream");
                    profile.SetPreference("pdfjs.disabled", true);
                    profile.AcceptUntrustedCertificates = true;
                    profile.SetPreference("security.insecure_password.ui.enabled", false);
                    profile.SetPreference("security.insecure_field_warning.contextual.enabled", false);

                    driver = new FirefoxDriver(profile);
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(GRMurl);
                    //driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
                    //FromSeconds(30);
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(GRMurl);
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
                  
                    break;
                default:
                    Console.WriteLine("Inavlid driver object Launching Firefox as browser of choice..");
                    break;

            }
            return driver;
        }

        //public IWebDriver LaunchingTheBrowserAndOpeningMarketplacePage()
        //{

        //    switch (BrowserType)
        //    {
        //        case "Chrome":
        //            ChromeOptions option = new ChromeOptions();
        //            option.AddArguments("disable-infobars");
        //            driver = new ChromeDriver(option);
        //            driver.Manage().Window.Maximize();
        //            driver.Navigate().GoToUrl(InstaURL);
        //            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
        //            break;

        //        case "Firefox":
        //            FirefoxProfile profile = new FirefoxProfile();
        //            profile.SetPreference("browser.download.folderList", 2);
        //            profile.SetPreference("browser.download.dir", "C:\\Windows\\temp");
        //            profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream");
        //            profile.SetPreference("pdfjs.disabled", true);
        //            profile.AcceptUntrustedCertificates = true;
        //            profile.SetPreference("security.insecure_password.ui.enabled", false);
        //            profile.SetPreference("security.insecure_field_warning.contextual.enabled", false);

        //            driver = new FirefoxDriver(profile);
        //            driver.Manage().Window.Maximize();
        //            driver.Navigate().GoToUrl(InstaURL);
        //            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
        //            //FromSeconds(30);
        //            break;

        //        case "IE":
        //            driver = new InternetExplorerDriver();
        //            driver.Manage().Window.Maximize();
        //            driver.Navigate().GoToUrl(InstaURL);
        //            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);

        //            break;
        //        default:
        //            Console.WriteLine("Inavlid driver object Launching Firefox as browser of choice..");
        //            break;

        //    }
        //    return driver;
        //}


        //public IWebDriver LaunchingTheBrowserAndOpeningMarketPlaceURL()
        //{
        //    GRMurl = InstaURL;
        //    return LaunchingTheBrowserAndOpeningGrmLoginPage();
        //}

        public IWebDriver LaunchingTheBrowserAndOpeningCreateCompanyOrHotelPage()
        {
            GRMurl = CreateCompanyURL;
            return LaunchingTheBrowserAndOpeningGrmLoginPage();
        }
        
        public IWebDriver LaunchingTheBrowserAndOpeningSignUpPage()
        {
            GRMurl = SignUpPageURL;
            return LaunchingTheBrowserAndOpeningGrmLoginPage();
        }

        public void CloseBrowser(ExtentReports extent)
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {

                var testName = TestContext.CurrentContext.Test.Name;
                string filename = testName ;

                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "<pre>";
                var errorMessage = TestContext.CurrentContext.Result.Message;


                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();

                string destination = ScreenshotPath + filename + ".jpeg";
                screenshot.SaveAsFile(destination, ScreenshotImageFormat.Jpeg);

                test.Log(LogStatus.Fail, testName + "  is Failed ");
                test.Log(LogStatus.Info, errorMessage);
                test.Log(LogStatus.Info, stackTrace);
                test.Log(LogStatus.Fail, test.AddScreenCapture(screenShotLocation + filename + ".jpeg"));
            }
            
            extent.EndTest(test);
            extent.Flush();
            driver.Quit();
            
        }


    }
}
