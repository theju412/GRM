using RelevantCodes.ExtentReports;
using System;
using System.Configuration;
using System.Globalization;
using System.IO;

namespace GRMAutomation.Utilities
{
    public class ReportGenerator
    {
        private static ExtentReports extent;
        

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                string extentReportPath = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings["extentReportPath"]);
                string reportName = DateTime.Now.ToString("yyyy-MM-dd~HH-mm", CultureInfo.CurrentCulture) + ".html";
                extent = new ExtentReports(extentReportPath + reportName, true);
                extent.LoadConfig(Directory.GetCurrentDirectory() + "extent-config.xml");
                extent.AddSystemInfo("Selenium version", "3.4").AddSystemInfo("ENV", "QA");
            }
            return extent;
        }
    }
}
