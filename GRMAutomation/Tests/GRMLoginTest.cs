using GRMAutomation.DataReader;
using GRMAutomation.PageObjects;
using GRMAutomation.Utilities;
using log4net;
using log4net.Config;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace GRMAutomation.Tests
{
    [TestFixture, Order(4)]
    class GRMLoginTest: ScreenCapturer
    {

        [SetUp]
        public void LauchingBrowser()
        {
            driver = LaunchingTheBrowserAndOpeningGrmLoginPage();
        }

        [Test, Order(1)]
        public void LoginToGRMWithValidCredentials()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(GRMLoginTest));

            test = extent.StartTest("Testing login functionality with valid credentials", "Entering valid user name and password");
            string UserNameValue = ExcelReaderHelper.GetCellData(fileLocation, "ValidCredentials", 1, 1).ToString();
            string PasswordValue = ExcelReaderHelper.GetCellData(fileLocation, "ValidCredentials", 2, 1).ToString();

            GRMLoginPage grmLoginObj = new GRMLoginPage(driver);
            grmLoginObj.IsGRMLogoPresent(log, test);
            grmLoginObj.SetUserName(UserNameValue, log, test);
            grmLoginObj.SetPassword(log, test, PasswordValue);
            grmLoginObj.ClickLoginButton(log, test);
            grmLoginObj.IsHomePageDisplayed();
            

        }

        [Test, Order(2)]
        public void LoginToGRMWithInvalidCredentails()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(GRMLoginTest));
            test = extent.StartTest("Testing login functionality with invalid credentials", "Entering invalid user name and password");
            GRMLoginPage grmLoginObj = new GRMLoginPage(driver);
            grmLoginObj.EnterInvalidUserNameAndPassword(log, test);
        }

        [Test, Order(3)]
        public void VerifyHomePageContentsForGRMBasedOnUserRole()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(GRMLoginTest));
            test = extent.StartTest("Testing Menus and Pages for GRM company", "Verifying menus and pages based on role and login user");
            GRMLoginPage Objgrm = new GRMLoginPage(driver);
            Objgrm.PageVerificationBasedOnUserRole(log, test);
        }

        [Test, Order(4)]
        public void VerifyHomePageContentsForMarketplcaceBasedOnUserRole()
        {
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(GRMLoginTest));
            test = extent.StartTest("Testing Menus and Pages for Marketplace company", "Verifying menus and pages based on role and login user");
            GRMLoginPage Objgrm = new GRMLoginPage(driver);
            Objgrm.MarketplaceCompanyPageVerification(log, test);
        }

        [TearDown]
        public void ClosingBrowser()
        {
            CloseBrowser(extent);

        }
    }
}
