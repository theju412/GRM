using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using GRMAutomation.BaseSetUp;
using System.Configuration;

namespace GRMAutomation.Utilities
{
    public class ScreenCapturer : BaseSetUpClass
    {
        public static ExtentReports extent = ReportGenerator.GetInstance();
        //public static ExtentTest test;
        public static new ScreenCapturer Create()
        {
            return new ScreenCapturer();
        }

        // public static string takeScreenshotPath = ConfigurationManager.AppSettings["takeScreenshotPath"];

        public string takeScreenshot(string filename)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
           
            //screenshot.SaveAsFile(takeScreenshotPath + filename + ".jpeg", ScreenshotImageFormat.Jpeg);
            string destination = ScreenshotPath + filename + ".jpeg";
            screenshot.SaveAsFile(destination, ScreenshotImageFormat.Jpeg);
            return destination;

        }
    }
}
