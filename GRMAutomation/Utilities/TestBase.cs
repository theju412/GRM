using System.Configuration;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Support.UI;
using System.Data;

namespace GRMAutomation.Utilities
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected ExtentTest test;
        protected WebDriverWait wait;
        protected DataSet dataSet;

        protected readonly string Image1FileLocation = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["Image1FileLocation"]);
        protected readonly string Image2FileLocation = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["Image2FileLocation"]);
        protected readonly string Image3FileLocation = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["Image3FileLocation"]);
        protected readonly string Image4FileLocation = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["Image4FileLocation"]);

        protected readonly string fileLocation = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["fileLocation"]);
        protected readonly string screenShotLocation = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["screenShotLocation"]);
        protected readonly string ScreenshotPath = ConfigurationManager.AppSettings["takeScreenshotPath"];
        protected readonly string LogoLocation = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["UploadingLogoPath"]);
        protected readonly string NonPdfFileLocation = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["UploadNonPdfFile"]);
      
    }
}